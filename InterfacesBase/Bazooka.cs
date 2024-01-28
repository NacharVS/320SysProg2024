using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Bazooka : IExplosiveWeapon
    {
        public int Damage => 35;

        public void ExplosionShoot()
        {
            Console.WriteLine($"Boom...The damage done is equal {Damage}");
        }
    }
}
