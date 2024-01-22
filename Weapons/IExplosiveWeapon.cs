using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface IExplosiveWeapon
    {
        public int splashDamage { get; }
        public void ExplosiveShoot();
    }
}
