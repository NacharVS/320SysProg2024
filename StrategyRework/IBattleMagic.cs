using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyRework
{
    internal interface IBattleMagic:IMagicUnit
    {
        public void Prayer();
    }
}
