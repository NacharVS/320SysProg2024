using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class PlasmaGrenade : IWeapon, IEnergyWeapon
    {
        public double Damage => 12;
        
        public int DamageEnergy => 10;

    }
}
