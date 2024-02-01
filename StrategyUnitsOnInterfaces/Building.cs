using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Building
    {
        public uint MaxEnergy { get; private set; }
        public uint Energy { get; set; }
        public Building()
        {
            Energy = 500;
            MaxEnergy = Energy;
        }
    }
}