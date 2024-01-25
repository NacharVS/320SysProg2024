using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Knife : IMeleeWeapon
    {
        public int Damage => 10;
        public int Sharpness => 8;
        public void Stab()
        {
            Console.WriteLine($"Сhwih! The sharpness this weapon was: {Sharpness}.");
        }
    }
}
