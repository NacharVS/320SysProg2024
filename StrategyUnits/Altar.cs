using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        public int MaxEnergy { get; private set; }
        private int _energy;
        public Altar(int energy)
        { 
            _energy = energy;
            MaxEnergy = energy;
        }
    }
}
