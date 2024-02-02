using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal interface IMagicUnit
    {
        public uint Mana { get; set; }

        public uint MaxMana { get; set; }

    }
}
