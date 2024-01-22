using System;

namespace InterfaceBaseTest
{
    internal class Machinegun : IWeapon, IAutomaticWeapon
    {
        public int Damage { get => 4; }

        public void BurstShoot()
        {
            int totalDamage = 0;
            for (int i = 0; i < 3; i++)
            {
                totalDamage += Damage;
            }
            Console.WriteLine($"Tra-ta-ta! Dealed{totalDamage}");
        }

        public void Shoot()
        {
            Console.WriteLine($"piu-piu! dealed {Damage}");
        }
    }
}
