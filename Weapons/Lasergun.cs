using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Lasergun : IAutomaticWeapon, ILazerWeapon
    {
        public int LazerDamage => 5;

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += LazerDamage;
            }
            Console.WriteLine($"Vio-vio! Dealed {totalDamage} lazer-energy damage");
        }

        public void LazerShoot()
        {
            Console.WriteLine($"BZZZZZZ! Dealed {LazerDamage * 3} lazer-energy damage in a huge single laser");
        }
    }
}
