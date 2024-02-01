using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IArmoredUnit
    {
        public int Protection { get; set; }
        public static int LvlArmor { get; set; }
    }
}
