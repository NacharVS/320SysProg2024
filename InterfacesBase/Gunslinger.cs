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

        public static void MultiShoot(IAutomaticWeapon weapon)
        {
            weapon.BurstShoot();
        }

        public static void Stab(IMleeWeapon weapon)
        {
            weapon.Stab();
        }
        public static void Hit(IMleeWeapon weapon)
        {
            weapon.Hit();
        }

        public static void Shoot(IEnergeWeapon weapon)
        {
            weapon.EnergyShoot();
        }
        public static void Shoot(IExplosiveWeapon weapon)
        {
            weapon.ExplosionShoot();
        }



    }
}
