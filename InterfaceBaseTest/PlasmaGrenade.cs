using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal class PlasmaGrenade : IWeapon, IExplosiveWeapon
    {
        public int Damage => 50;

        public int Span => 3;

        public void Explode()
        {
            Console.WriteLine($"boom! dealed {Damage}, span - {Span}");
        }
    }
}
