using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Footman : MilitaryUnit
    {

        public Footman(int health, string name, int damage) : base(health, name, damage)
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
