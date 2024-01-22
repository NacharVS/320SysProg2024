using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface IMeleeWeapon
    {
        public int Durability { get; set; }
        public int MeleeDamage { get; }
        public void MeleeAttack();
    }
}
