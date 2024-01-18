using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public Altar()
        {
            _energy = 20;
            MaxEnergy = 20;
        }
        public int Energy
        {
            get { return _energy; }
            set { 
                if (value > MaxEnergy)
                    value = MaxEnergy;
                else if (value < 0)
                    value = 0;
                else
                    _energy = value;
            }
        }
        public void HealAltar(MagicUnit unit)
        {
            while (unit.Manna < unit.MaxManna)
            {
                Energy -= 1;
                unit.Manna += 10;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Altar energy: {Energy}");
        }
    }
}
