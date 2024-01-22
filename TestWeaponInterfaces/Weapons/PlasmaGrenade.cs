using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces.Weapons
{
    internal class PlasmaGrenade : IWeapon, IEnergyWeapon
    {
        public int PhysicalDamage => 3;

        public int EnergyDamage => 6;

        public void PulseShot()
        {
            Console.WriteLine($"Бабах. PhysicalDamage: {PhysicalDamage}, EnergyDamage: {EnergyDamage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {GetType()}");
        }

    }
}
