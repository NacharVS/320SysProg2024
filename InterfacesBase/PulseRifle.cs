using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PulseRifle : IWeapon, IEnergyWeapon
    {
        public int Damage => 80;

        public int Energy => 50;

        public void EnergyShoot()
        {
            Console.WriteLine($"{Energy} energies were spent");
        }
    }
}
