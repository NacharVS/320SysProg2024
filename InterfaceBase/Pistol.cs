using System;

namespace InterfaceBase
{
    internal class Pistol
    {
        public int Damage => 7;

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}");
        }
    }
}
