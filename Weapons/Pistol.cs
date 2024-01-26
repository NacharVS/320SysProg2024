﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Pistol : IWeapon
    {
        public int Damage => 7;

        public void Shoot()
        {
            Console.WriteLine($"Piu-piu! Dealed {Damage} damage");
        }
    }
}