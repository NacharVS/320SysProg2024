using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PulseRifle : IEnergeWeapon
    {
        public int Damage => 25;
        public void EnergyShoot()
        {
            Console.WriteLine($"Ba-Dump. Dealed {Damage}");
        }
    }
}
