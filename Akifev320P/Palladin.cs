using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Palladin : MagicUnit
    {
 
       

        public Palladin() : base(60, "Palladin", 15, 55)
        {     
            
        }

        public void The_punitive_sword_of_justice(Unit unit)
        {
            if (unit.isAlive)
            {
                while (manna >= 10)
                {
                    unit.Health -= 20;
                    _manna -= 10;
                    Console.WriteLine($"Palladin used the skill and took down 20 HP");
                }
            }
           else if(manna<10)
            {
                Console.WriteLine($"\r\nNot enough mana! Mana - {_manna}");
            }
            else 
            {
                Console.WriteLine("Object is dead");
            }
        }

    }
}
