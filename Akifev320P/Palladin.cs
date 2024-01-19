using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Palladin : MagicUnit
    {
        private int _damage;

        public Palladin() : base(60, "Palladin", 15, 55)
        {     
            
        }

        public void The_punitive_sword_of_justice(Unit unit)
        {
            if (unit.isAlive)
            {
                while (Manna >= 10)
                {
                    _damage = 20;
                    Manna -= 10;
                }
            }
            else
            {
                Console.WriteLine("Object is dead");
            }
        }

    }
}
