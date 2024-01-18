using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MillitaryUnit : Unit
    {
        private int _minDamage;

        private int _maxDamage;

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

        public MillitaryUnit(int minDamage, int maxDamage, string? name, int Health) : base(Health, name)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        public void InflictDamage(Unit unit)
        {
            Random rnd = new Random();
            if (unit.isAlive)
            {
                unit.Health -= rnd.Next(_minDamage, _maxDamage);
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
    }
}
