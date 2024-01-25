using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class LaserRifle: IWeapon, IEnergeWeapon
    {
        public int Damage => 18;
        public int Energy => 21;
        public void HitEnergy()
        {
            Console.WriteLine($"Pew! The energy of this hit was: {Energy}.");
        }
    }
}
