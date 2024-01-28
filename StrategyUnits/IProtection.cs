using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IProtection
    {
        public double Protection { get; set; }
        public static int LvlArmor { get; set; }
    }
}
