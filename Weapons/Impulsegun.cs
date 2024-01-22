using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Impulsegun : IEnergyWeapon
    {
        public int EnergyDamage => 15;
        public void EnergyShoot()
        {
            Console.WriteLine($"Zzap-zzap! Dealed {EnergyDamage} energy damage");
        }
    }
}
