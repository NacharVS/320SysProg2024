using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
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

        public static void Throw(IGrenade grenade)
        {
            grenade.Throw();
        }

        public static void Hit(IMeleeWeapon meleeWeapon)
        {
            meleeWeapon.Hit();
        }
    }
}
