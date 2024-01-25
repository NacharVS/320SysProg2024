using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal class Knife : IMleeWeapon
    {
        public int Damage => 5;
        
        public int Endurance => 7;

        public void Hit()
        {
            Console.WriteLine($"hit! dealed {Damage}, endurance - {Endurance}");
        }
    }
}
