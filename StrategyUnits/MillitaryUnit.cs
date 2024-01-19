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

        private protected int _maxDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public virtual int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public MillitaryUnit(int minDamage, int maxDamage, string? name, int Health, int protection) : base(Health, name, protection)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        public void InflictDamage(Unit unit)
        {
            if (!isAlive)
            {
                Console.WriteLine($"{Name} is dead");
                return;
            }
            Random rnd = new Random();
            if (unit.isAlive)
            {
                int damage = rnd.Next(_minDamage, _maxDamage);
                if (damage>unit.Protection)
                    unit.Health -= (damage-unit.Protection);
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} Damage: {_minDamage}-{MaxDamage} HP:{Health}/{MaxHealth}");
        }
    }
}
