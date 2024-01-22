using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Weapons
{
    internal class Pistol : ISingleWeapon, IWeapon, IRepairableWeapon
    {
        public int PhysicalDamage => 6;

        public double Durability
        {
            get => 6;
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

        public void Shoot()
        {
            Console.WriteLine($"Пиу, Damage: {PhysicalDamage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {GetType()}");
        }

    }
}
