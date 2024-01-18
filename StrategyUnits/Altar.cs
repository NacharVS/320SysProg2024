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
        private int _Energy;
        private int _MaxEnergy;

        public int MaxEnergy
        {
            get { return _Energy; }
            set { _Energy = value; }
        }

        public Altar()
        {
            _Energy = 1000;
            MaxEnergy = _Energy;
        }

        public int Energy
        {
            get { return _Energy; }
            set
            {
                if (value < 0)
                    _Energy = 0;
                else
                    if (value > MaxEnergy)
                    _Energy = MaxEnergy;
                else
                    _Energy = value;
            }
        }

        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Energy right now: {Energy}.");
        }
    }
}
