using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class LaserRifle : IEnergyWeapon
    {
        public int Damage => 18;
        public int Energy => 21;
        public void ShootEnergy()
        {
            Console.WriteLine($"Pew! The energy of this hit was: {Energy}.");
        }
    }
}
