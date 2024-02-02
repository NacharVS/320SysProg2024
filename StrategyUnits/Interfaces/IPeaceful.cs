using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IPeaceful 
    {
        public bool IsWorking { get; set; }
        public void EndWork();
        public void StartWork();
    }
}
