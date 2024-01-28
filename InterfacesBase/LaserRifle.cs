using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class LaserRifle : IEnergeWeapon
    {
        public int Damage => 15;
        public void EnergyShoot()
        {
            Console.WriteLine($"Ba-Dump. Dealed {Damage}");
        }
    }
}
