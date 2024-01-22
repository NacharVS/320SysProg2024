using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal class Knife : IMeleeWeapon
    {
        public int MeleeDamage => 10;
        public void MeleeAttack()
        {
            Console.WriteLine($"Wheep! Dealed {MeleeDamage} melee damage");
        }
    }
}
