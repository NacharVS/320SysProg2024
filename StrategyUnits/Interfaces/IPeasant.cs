using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IPeasant
    {
        public int QuanRecources { get; set; }
        public void Collecting();
    }
}
