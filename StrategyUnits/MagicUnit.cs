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

        public int NowEnergy
        {
            get { return _nowEnergy; }
            set
            {
                if (value > MaxEnergy)
                    _nowEnergy = _maxEnergy;
                else if (value < 0)
                    _nowEnergy = 0;
                else
                    _nowEnergy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public MagicUnit(string? name, int health, int damage, int maxEnergy, int nowEnergy) : base(name, health, damage)
        {
            _maxEnergy = maxEnergy;
            _nowEnergy = nowEnergy;
        }

        public override void Attack(Unit unit)
        {
            unit.Health -= Damage;
            Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name} ножом");
        }
        //За одно очко энергии убавляется 3 очка жизни
        public virtual void MagicAttack(Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine($"Персонаж {unit.Name} мертв! Его нельзя атаковать!");
                return;
            }
            
            while (unit.DiedUnit == false || _nowEnergy > 0)
            {
                 _nowEnergy -= 1;
                 unit.Health -= 3;
            }
            Console.WriteLine($"Персонажу {unit.Name} нанесено максимальное количество урона. Он мертв.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Energy: {_nowEnergy}");
        }

    }
}

