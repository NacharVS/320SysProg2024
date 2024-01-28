using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pistol pistol = new Pistol();
            Machinegun pp = new Machinegun();
            Knife knife = new Knife();
            Bazooka bazooka = new Bazooka();
            LaserRifle laser = new LaserRifle();

            Gunslinger.SingleShoot(pp);
            Gunslinger.MultiShoot(pp);
            Gunslinger.Shoot(bazooka);
            Gunslinger.Shoot(laser);


            // 1. Реализовать Нож, Базуку, Лазерную винтовку, Плазменная граната, Импульсная винтовка
            // 2. IMleeWeapon, IExplosiveWeapon, IEnergeWeapon
        }
    }
}
