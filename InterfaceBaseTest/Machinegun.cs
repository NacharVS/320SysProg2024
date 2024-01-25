using System;

namespace InterfaceBaseTest
{
    internal class Machinegun : IWeapon, IRangeWeapon, IAutomaticWeapon
    {
        public int Damage { get => 4; }

        public int Range => 100;

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Damage;
            }
            Console.WriteLine($"Tra-ta-ta! Dealed{totalDamage}, range - {Range}");
        }

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}, range - {Range}");
        }
    }
}
