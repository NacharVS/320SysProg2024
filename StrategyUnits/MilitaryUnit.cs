using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private protected int _minDamage;
        private protected int _maxDamage;
        private int _shield;
        internal int _levelDamage = 0;
        internal int _levelShield = 0;

        public virtual int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public virtual int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int Shield
        {
            get { return _shield; }
            set { _shield = value; }
        } 

        public MilitaryUnit(string? name, int health, int minDamage, int maxDamage, int shield) : base(name, health)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _shield = shield;
        }

        public void InflictDamage(Unit unit)
        {
            Random random = new Random();
            int damage = random.Next(MinDamage, MaxDamage + 1);
            if (unit is MilitaryUnit)
            {
                MilitaryUnit militaryUnit = (MilitaryUnit)unit;
                Console.WriteLine($"\n{militaryUnit.Name} - Shield: {militaryUnit.Shield}");
                damage -= militaryUnit.Shield;
            }
            if (damage > 0)
            {
                Console.WriteLine();
                unit.Health -= damage;
            }
            else
            {
                Console.WriteLine("Защита не пробита");
            }
        }
    }
}
