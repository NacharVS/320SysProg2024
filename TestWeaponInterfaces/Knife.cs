using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeaponInterfaces.Interfaces;

namespace TestWeaponInterfaces
{
    internal class Knife : IMeleeWeapon, IWeapon
    {
        public int Damage => 15;

        public void ShowGun()
        {
            Console.WriteLine($"Вы осмотрели {this.GetType()}");
        }

        public void Stab()
        {
            Console.WriteLine($"Режик Damage: {Damage}");
        }
    }
}
