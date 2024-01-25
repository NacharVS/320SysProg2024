using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    internal interface IExplosiveWeapon
    {
        public int Range { get;  }
        public void Explode();
    }
}
