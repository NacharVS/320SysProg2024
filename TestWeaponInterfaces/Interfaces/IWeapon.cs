using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeaponInterfaces.Interfaces
{
    internal interface IWeapon
    {
        public int Damage { get; }
        public void ShowGun();
    }
}
