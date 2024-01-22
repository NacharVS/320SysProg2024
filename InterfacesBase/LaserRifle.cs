using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class LaserRifle : IWeapon, IEnergyWeapon
    {
        public int Damage => 70;

        public int Energy => 50;

        public void EnergyShoot()
        {
            Console.WriteLine($"{Energy} energies were spent");
        }
    }
}
