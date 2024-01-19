using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Footman : MilitaryUnit
    {

        public Footman() : base(60, "Footman", 7, 0)
        {

        }
        public void InflictDamage(Unit unit)
        {
            if (unit.isAlive)
            {
                unit.Health -= Damage;
            }
            else
            {
                Console.WriteLine("Object is dead");
            }

        }
    }
}
