using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfase
{
    internal interface IArmor
    {
        public int Defense { get; set; }
        public int ArmorLvl { get; set; }
    }
}
