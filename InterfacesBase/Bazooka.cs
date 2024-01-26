using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Bazooka : IWeapon, IExplosiveWeapon
    {
        public int Damage => 50;

        public int Range => 135;

        public void BurstUp()
        {
            Console.WriteLine($"Booms! The range of destruction was: {Range}, Damage: {Damage}");
        }
    }
}
