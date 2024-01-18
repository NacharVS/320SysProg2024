using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _minDamage;
        private int _maxDamage;
        private string _weapon;
        private int _shield;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }
        public int Shield
        {
            get { return _shield; }
            set { _shield = value; }
        }

        public MilitaryUnit(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield) : base(name, maxHealth)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _weapon = weapon;
            _shield = shield;
        }

        public bool Attack(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может атаковать");
                return false;
            }
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Не нужно больше его атаковать");
                return false;
            }
            Random random = new Random();
            int damage = random.Next( MinDamage, MaxDamage + 1 );
            Console.Write($"{Name} атаковал {Weapon} {unit.Name}");
            if(unit is MilitaryUnit)
            {
                MilitaryUnit militaryUnit = (MilitaryUnit)unit;
                Console.Write($" на {damage}. {militaryUnit.Name} имеет защиту {militaryUnit.Shield}. ");
                damage -= militaryUnit.Shield;
            }
            else
                Console.WriteLine();
            if(damage > 0)
            {
                Console.WriteLine();
                unit.Health -= damage;
            }
            else
            {
                Console.WriteLine("Защита не пробита");
            }
            return true;
        }
    }
}
