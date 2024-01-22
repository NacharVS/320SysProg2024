using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Machinegun : IWeapon, IAutomaticWeapon
    {
        public int Damage => 4;

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Damage;
            }
            Console.WriteLine($"Tra-ta-ta! Dealed {totalDamage} damage");
        }

        public void Shoot()
        {
            Console.WriteLine($"Piu-piu! Dealed {Damage} damage");
        }
    }
}
