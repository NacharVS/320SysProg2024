using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _minDamage;
        private int _maxDamage;
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
