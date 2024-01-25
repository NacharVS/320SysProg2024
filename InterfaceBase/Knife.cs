using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Knife : IWeapon, IMeleeWeapon
    {
        public double Damage => 5;

       
        public void Strike()
        {
            Console.WriteLine($"Вы нанесли удар ножом. Урон = {Damage}");
        }

        

    }
}
