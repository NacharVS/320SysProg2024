using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces
{
    internal class Machinegun : IWeapon, ISingleWeapon, IAutomaticWeapon
    {
        public int Damage => 3;

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Damage;
            }
            Console.WriteLine($"Тра-та-та. Total damage: {totalDamage}");
        }

        public void Shoot()
        {
            Console.WriteLine($"Пау. Damage: {Damage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {this.GetType()}");
        }

    }
}
