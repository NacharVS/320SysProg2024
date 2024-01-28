using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PlasmaGrenade : IEnergeWeapon
    {
        public int Damage => 45;
        public void EnergyShoot()
        {
            Console.WriteLine($"Boom. Dealed {Damage}");
        }
    }
}
