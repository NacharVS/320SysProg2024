using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal interface IExplosiveWeapon
    {
        public int ExplosiveDamage { get; }
    }
}
