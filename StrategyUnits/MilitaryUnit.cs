using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;
        public event HealthChangedDelegate MilitaryUnitDamage;
        public MilitaryUnit(int health, string? name) : base(health, name)
        {
        }
        public virtual void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
    }
}
