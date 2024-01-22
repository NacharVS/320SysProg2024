using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Weapons
{
    internal class Machinegun : IWeapon, ISingleWeapon, IAutomaticWeapon, IRepairableWeapon
    {
        public int PhysicalDamage => 3;

        public double Durability
        {
            get => 8;
            set
            {
                if (Durability <= 0)
                {
                    Durability = 0;
                    IsBroken = true;
                }
                else
                {
                    Durability = value;
                }
            }
        }
        public bool IsBroken
        {
            get => false;
            set { IsBroken = value; }
        }

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += PhysicalDamage;
            }
            Console.WriteLine($"Тра-та-та. Total damage: {totalDamage}");
        }

        public void Shoot()
        {
            Console.WriteLine($"Пау. Damage: {PhysicalDamage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {GetType()}");
        }

    }
}
