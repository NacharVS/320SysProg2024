using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagical
    {
        public int ManaPoints { get; set; }
        public int MaxManaPoints { get; set; }
        public void DecreaseEnergy(int manaPoints);
        public void IncreaseEnergy(int manaPoints);

        public delegate void EnergyChangedDelegate(string name, int manaPoints, int MaxManaPoints);
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
    }

}
