using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class Pistol: IAutomaticWeapon
    {
        public int Damage => 7;

        public void BurstShoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}");
        }
    }
}
