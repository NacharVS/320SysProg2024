using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal class Pistol : IWeapon, IRangeWeapon
    {
        public int Damage => 7;

        public int Range => 5;

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}, range - {Range}");
        }
    }
}
