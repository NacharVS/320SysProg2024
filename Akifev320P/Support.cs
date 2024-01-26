using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Akifev320P
{
    internal class Support : MagicUnit
    {
        
        public Support() : base(35, "Support", 5, 60)
        {
           
        }

        public Support(int health, string name, int damage, int manna) : base(health, name, damage, manna)
        {
        }

        //public void selfHeal()
        // {
        //     while (Manna >= 3)
        //     {
        //         Health += 1;
        //         Manna -= 2;
        //     }
        // }

        public void Heal(Unit unit)
        {
            if (unit.isAlive)
            {
                while (manna >= 5 && unit.Health < unit.MaxHealth )
                {
                    unit.Health += 1;
                    manna -= 2;
                    Console.WriteLine($"Support heal on 1 HP");
                }
            }
            else
            {
                Console.WriteLine("Object is dead");
            }
        }

     

    }
}
