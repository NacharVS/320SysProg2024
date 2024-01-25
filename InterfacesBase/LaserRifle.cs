using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class LaserRifle : IWeapon, IEnergyWeapon
    {
        public int Damage => 6;

        public int EnergyDamage => 10;

        public void Shoot()
        {
            Console.WriteLine($"Dealed {Damage} damage and {EnergyDamage} energy damage by laser rifle");
        }
    }
}
