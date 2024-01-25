using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class PlasmaGrenade : IExplosiveWeapon
    {
        public int Damage => 65;

        public int Range => 50;

        public void BurstUp()
        {
            Console.WriteLine($"Booms! The range of destruction was: {Range}");
        }
    }
}
