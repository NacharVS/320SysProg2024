using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal interface IEnergyWeapon : IWeapon
    {
        public int Energy { get; }
        public void ShootEnergy();
    }
}
