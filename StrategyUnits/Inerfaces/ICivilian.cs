using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface ICivilian
    {
        public bool IsWorking { get; set; }
        public void FinishWork();
        public void PlowField();
    }
}
