using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicPower
    {
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public void DecreaseEnergy(int energy);
        public void IncreaseEnergy(int energy);
        public delegate void EnergyChangedDelegate(string name, int energy, int energy1, int maxEnergy);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
