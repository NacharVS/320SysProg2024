using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBase
{
    internal interface IMeleeWeapon
    {
        public int Sharpness { get; }
        public void Stab();
    }
}
