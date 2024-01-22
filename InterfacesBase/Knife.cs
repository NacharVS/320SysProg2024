using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Knife : IMeleeWeapon, IWeapon
    {
        public int Sharpness => 8;

        public int Damage => 10;

        public void Hit()
        {
            Console.WriteLine($"vcik! Sharpness {Sharpness}");
        }
    }
}
