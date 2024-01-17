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
        private int _maxEnergy;
        private int _nowEnergy;
        private int _damageMagic;

        public delegate void EnergyChangedDelegate(string name, int energy, int difference);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
        public int NowEnergy
        {
            get { return _nowEnergy; }
            set
            {
                int previousEnergy = _nowEnergy;
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
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }

        public int DamageMagic
        {
            get { return _damageMagic; }
            set { _damageMagic = value; }
        }
        public MagicUnit(string? name, int health, int damage, int maxEnergy, int defence, int damagemagic) : base(name, health, damage, defence)
        {
            _maxEnergy = maxEnergy;
            _nowEnergy = maxEnergy;
            _damageMagic = damagemagic;
        }

        public override void Attack(Unit unit)
        {
            if (unit.DiedUnit == false)
            {
                unit.Health -= (Damage - unit.Defence);
                Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name} мечом");
            }
            else
                Console.WriteLine($"Нельзя нанести урон персонажу {unit.Name}. Он уже мертв");
        }
        //За одно очко энергии убавляется 3 очка жизни
        public void MagicAttack(Unit unit)
        {
            if (unit.DiedUnit == false && NowEnergy > 0)
            {
                 NowEnergy -= 1;
                 unit.Health -= (Damage - unit.Defence);
                Console.WriteLine($"Персонажу {unit.Name} нанесен урон с помощью магического удара.");
            }
            else
            {
                Console.WriteLine($"Невозможно использовать магический удар. Персонаж {unit.Name} уже мертв.");
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Жизни: {Health} Энергия: {_nowEnergy}");
        }

    }
}

