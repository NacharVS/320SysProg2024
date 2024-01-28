using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicAbilities
    {
        public double Energy { get; set; }
        public double MaxEnergy { get; set; }
        public void DecreaseEnergy(double energy);
        public void IncreaseEnergy(double energy);
        public delegate void EnergyChangedDelegate(string name, double energy);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;

    }
}
