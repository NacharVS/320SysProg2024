using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IArmoredUnit
    {
        public int Defense { get; set; }
        public static int ArmorLvl { get; set; }
    }
}
