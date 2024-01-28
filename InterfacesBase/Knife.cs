using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Knife : IMleeWeapon
    {
        public int Damage => 7;

        public void Hit()
        {
            Console.WriteLine($"Сrack. Dealed {Damage}");
        }

        public void Stab()
        {
            Console.WriteLine($"Chak - chak. Dealed {Damage}");
        }
    }
}
