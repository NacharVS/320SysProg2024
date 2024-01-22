using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Weapons
{
    internal class PulseRifle : IWeapon, IEnergyWeapon, IRepairableWeapon
    {
        public int PhysicalDamage => 5;

        public int EnergyDamage => 9;

        public double Durability
        {
            get => 5;
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
        public void PulseShot()
        {
            Console.WriteLine($"Увиииинь. PhysicalDamage: {PhysicalDamage}, EnergyDamage: {EnergyDamage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {GetType()}");
        }

    }
}
