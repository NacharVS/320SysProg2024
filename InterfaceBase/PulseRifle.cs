using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class PulseRifle: IWeapon, IEnergeWeapon
    {
        public int Damage => 30;
        public int Energy => 27;

        public void HitEnergy()
        {
            Console.WriteLine($"Pew! The energy of this hit was: {Energy}.");
        }
    }
}
