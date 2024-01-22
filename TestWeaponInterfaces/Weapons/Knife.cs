using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Weapons
{
    internal class Knife : IMeleeWeapon, IWeapon, IRepairableWeapon
    {
        public int PhysicalDamage => 15;

        public double Durability
        {
            get => 10;
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

        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {GetType()}");
        }

        public void Stab()
        {
            Console.WriteLine($"Режик. Damage: {PhysicalDamage}. ");
        }
    }
}
