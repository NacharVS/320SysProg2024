using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Bazooka : IWeapon, IExplosiveWeapon
    {
        public double Damage => 10;
        public double Range => 100;

        public void Explosion()
        {
            Console.WriteLine($"Вы выстрелили из базуки. Урон = {Damage}");
        }

    }
}
