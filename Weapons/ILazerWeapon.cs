using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    internal interface ILazerWeapon
    {
        public int LazerDamage { get; }
        public void LazerShoot();
    }
}
