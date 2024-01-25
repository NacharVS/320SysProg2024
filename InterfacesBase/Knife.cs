using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal class Knife : IMeleeWeapon
    {
        public int MeleeDamage => 9;

        public void Hit()
        {
            Console.WriteLine($"Dealed {MeleeDamage} melee damage by knife");
        }
    }
}