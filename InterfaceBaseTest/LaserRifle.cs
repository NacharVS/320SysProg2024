using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal class LaserRifle : IWeapon, IRangeWeapon, IEnergeWeapon
    {
        public int Damage => 15;

        public int Range => 250;

        public int Energy => 3;

        public void Shoot()
        {
            Console.WriteLine($"shoot! dealed {Damage}, range - {Range}, energy - {Energy}");
        }
    }
}
