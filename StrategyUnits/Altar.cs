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

        //
        public void RegenerationManna(IMagicUnitCapability unit)
        {
            var EnergyBefore = unit.Change_manna; 
            while (_Energy > 0)
            {
                while (unit.Change_manna < unit.MaxManna)
                {
                    unit.Change_manna += 1;
                    _Energy--;
                }
                return;
            }
        }
        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight(55, 60, "Zealot knight", false, 6, 10, 30, 4);
        }
        public Palladin CreatePalladin()
        {
            return new Palladin(60, 65, "Paladin", false, 10, 30, 31, 5, 8);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", false, 15, 30, 20, 20, 4);
        }
        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Energy right now: {Energy}.");
        }
    }
}
