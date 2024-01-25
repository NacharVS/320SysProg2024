using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBaseTest
{
    internal class Bazooka : IWeapon, IExplosiveWeapon
    {
        public int Damage => 20;

        public int Span => 5;

        public void Explode()
        {
            Console.WriteLine($"boom! dealed {Damage}");
        }
    }
}
