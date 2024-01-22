using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Bazooka : IWeapon, IExplosiveWeapon
    {
        public int Damage => 100;

        public int Radius => 60;

        public void Explosion()
        {
            Console.WriteLine($"BOOM! Explosion in radius {Radius}");
        }
    }
}
