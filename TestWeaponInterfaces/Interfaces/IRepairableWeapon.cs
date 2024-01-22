using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeaponInterfaces.Interfaces
{
    internal interface IRepairableWeapon
    {
        public double Durability { get; set; }
        public bool IsBroken { get; set; }

    }
}
