using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal static class Gunslinger
    {
        public static void SingleShoot(IWeapon weapon)
        {
            weapon.Shoot();
        }

        public static void SerialShoot(IAutomaticWeapon weapon)
        {
            weapon.BurstFire();
        }
    }
}
