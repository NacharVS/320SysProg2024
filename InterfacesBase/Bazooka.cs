using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Bazooka : IExplosiveWeapon, IWeapon
    {
        public int ExplosiveDamage => 7;

        public int Damage => 5;

        public void Shoot()
        {
            Console.WriteLine($"Caboom! Dealed {Damage} damage and {ExplosiveDamage} explosive damage by bazooka");
        }
    }
}
