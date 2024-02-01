using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyUnits.Units.MagicUnit;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit
    {
        public int MaxEnergy { get; set; }
        public int CurrentEnergy { get; set; }


        public delegate void EnergyChangedDelegate(string name, int energy, int difference, int maxEnergy);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
