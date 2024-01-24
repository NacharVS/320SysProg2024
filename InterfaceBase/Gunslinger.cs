using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Gunslinger
    {
        public static void SingleShoot(IWeapon weapon)
        {
            weapon.Shoot();
        }

        public static void MultiShoot(IAutomaticWeapon weapon)
        {
            weapon.BurstShoot();
        }
    }
}
