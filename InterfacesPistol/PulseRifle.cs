using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPistol
{
    internal class PulseRifle : IWeapon, IEnergyWeapon
    {
        public int Damage => 20;
        public int Energy => 25;
        public void ShootEnergy()
        {
            Console.WriteLine($"Pew! The energy of this hit was: {Energy}.");
        }
    }
}
