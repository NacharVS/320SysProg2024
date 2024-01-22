using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class PlazmGrenade : IExplosiveWeapon, IEnergyWeapon
    {
        public int splashDamage => 40;

        public int EnergyDamage => 10;

        public void EnergyShoot()
        {
            Console.WriteLine($"BOOM-bzzz! Dealed {splashDamage + EnergyDamage} splash energy damage");
        }

        public void ExplosiveShoot()
        {
            Console.WriteLine($"BOOM! Dealed {splashDamage} splash energy damage");
        }
    }
}
