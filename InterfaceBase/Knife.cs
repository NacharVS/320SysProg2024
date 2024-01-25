using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Knife: IWeapon, IMleeWeapon
    {
        public int Damage => 10;
        public int Sharpness => 8;
        public void Hit()
        {
            Console.WriteLine($"Сhwih! The sharpness this weapon was: {Sharpness}.");
        }
    }
}
