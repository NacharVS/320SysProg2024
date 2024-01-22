using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces
{
    internal class Pistol : ISingleWeapon, IWeapon
    {
        public int Damage => 6;

        public void Shoot()
        {
            Console.WriteLine($"Пиу, Damage: {Damage}");
        }
        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {this.GetType()}");
        }

    }
}
