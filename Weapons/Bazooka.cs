using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Bazooka : IExplosiveWeapon
    {
        public int splashDamage => 25;

        public void ExplosiveShoot()
        {
            Console.WriteLine($"BOOM! Dealed {splashDamage} splash damage");
        }
    }
}
