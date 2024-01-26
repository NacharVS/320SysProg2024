using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnit
    {
        public int Manna { get; set; }
        public int MaxManns { get; set; }
    }
}
