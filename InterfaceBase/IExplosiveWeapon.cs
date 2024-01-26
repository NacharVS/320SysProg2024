using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBase
{
    public interface IExplosiveWeapon
    {
        double Range { get; }
        void Explosion();
    }
}
