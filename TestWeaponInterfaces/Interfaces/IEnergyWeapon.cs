using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeaponInterfaces.Interfaces
{
    internal interface IEnergyWeapon
    {
        public int EnergyDamage { get; }
        public void PulseShot();

    }
}
