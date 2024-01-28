using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IArmor
    {
        public int Guard { get; set; }
        public static int LevelArmor { get; set; }
    }
}
