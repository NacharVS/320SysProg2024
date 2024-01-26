using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPistol
{
    internal interface IExplosiveWeapon : IWeapon
    {
        public int Range { get; }
        public void BurstUp();
    }
}
