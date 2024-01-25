using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal interface IEnergeWeapon
    {
        public int Energy { get; }
        public void HitEnergy();
    }
}
