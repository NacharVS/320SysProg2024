using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private double _maxEnergy;
        private double _nowEnergy;

        public delegate void EnergyChangedDelegate(string name, double energy, double difference);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
        public double NowEnergy
        {
            get { return _nowEnergy; }
            set
            {
                double previousEnergy = _nowEnergy;
                if (value > MaxEnergy)
                    _nowEnergy = _maxEnergy;
                else if (value <= 0)
                    _nowEnergy = 0;
                else
                    _nowEnergy = value;

                if (value < previousEnergy)
                {
                    EnergyDecreasedEvent.Invoke(this.Name, NowEnergy, previousEnergy - value);
                }
                else if (value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(this.Name, NowEnergy, value - previousEnergy);
                }
            }
        }
        public double MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }

        public MagicUnit(string? name, double health, double damage, double maxEnergy, double defence) : base(name, health, damage, defence)
        {
            _maxEnergy = maxEnergy;
            _nowEnergy = maxEnergy;
        }

        public override void Attack(Unit unit)
        {
            if (unit.DiedUnit == false)
            {
                unit.Health -= (Damage - unit.Defence);
                Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name} ножом");
            }
            else
                Console.WriteLine($"Нельзя нанести урон персонажу {unit.Name}. Он уже мертв");
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Жизни: {Health} Энергия: {_nowEnergy} Урон: {Damage} Уровень защиты: {LvlWeapon} Уровень оружия: {LvlArmor}");
        }

    }
}

