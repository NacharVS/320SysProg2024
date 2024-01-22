using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
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

        public static void ExplosiveShoot(IExplosiveWeapon weapon)
        {
            weapon.ExplosiveShoot();
        }

        public static void EnergyShoot(IEnergyWeapon weapon)
        {
            weapon.EnergyShoot();
        }

        public static void MeleeAttack(IMeleeWeapon weapon)
        {
            weapon.MeleeAttack();
        }

        public static void LazerShoot(ILazerWeapon weapon)
        {
            weapon.LazerShoot();
        }

        public static void ExplosivePlazmaShoot(IEnergyWeapon weapon)
        {
            weapon.EnergyShoot();
        }
    }
}
