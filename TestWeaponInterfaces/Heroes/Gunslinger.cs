using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Heroes
{
    internal static class Gunslinger
    {
        public static void SingleShoot(ISingleWeapon weapon)
        {
            weapon.Shoot();
        }
        public static void MultiShoot(IAutomaticWeapon weapon)
        {
            weapon.BurstShoot();
        }
        public static void Stab(IMeleeWeapon weapon)
        {
            weapon.Stab();
        }
        public static void AimedShot(IEnergyWeapon weapon)
        {
            weapon.PulseShot();
        }
        public static void PulseShot(IEnergyWeapon weapon)
        {
            weapon.PulseShot();
        }
        public static void ExplosionShot(IExplosiveWeapon weapon)
        {
            weapon.Explosion();
        }

        public static void ShowGun(IWeapon weapon)
        {
            weapon.ShowGun();
        }


    }
}
