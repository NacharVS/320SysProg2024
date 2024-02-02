using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrategyUnitsOnInterfaces
{
    internal class Building
    {
        public int MaxEnergy { get; private set; }
        private int _energy;
        public int Energy
        {
            get { return _energy;}
            set
            {
                if (value > MaxEnergy)
                    _energy = MaxEnergy;
                else if (value < 0)
                {
                    _energy = 0;
                }
                else
                    _energy ++;
            }
        }
        public Building()
        {
            _energy = 500;
            MaxEnergy = _energy;
        }
    }
}