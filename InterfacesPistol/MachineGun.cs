﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPistol
{
    internal class MachineGun : IWeapon, IAutomaticWeapon
    {
        public int Damage { get => 4; }

        public void BurstFire()
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