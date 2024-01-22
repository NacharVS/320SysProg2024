using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces
{
    internal class PlasmaGrenade : IWeapon, IEnergyWeapon
    {
        public int Damage => 6;

        public void PulseShoot()
        {
            Console.WriteLine($"Бабах. amage: {Damage}");

        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {this.GetType()}");
        }

    }
}
