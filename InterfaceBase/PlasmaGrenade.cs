using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal class PlasmaGrenade: IWeapon, IExplosiveWeapon
    {
        public int Damage => 65;

        public int Range => 50;

        public void Explode()
        {
            Console.WriteLine($"Booms! The range of destruction was: {Range}");
        }

    }
}
