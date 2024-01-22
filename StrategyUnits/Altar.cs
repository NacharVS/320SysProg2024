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
        public void RegenerationManna(MagicUnit magicUnit)
        {
            var EnergyBefore = magicUnit.Manna; 
            while (_Energy > 0)
            {
                while (magicUnit.Manna < magicUnit.MaxManna)
                {
                    magicUnit.Manna += 10;
                    _Energy--;
                }
                return;
            }
        }
        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight(55, "Zealot knight", 6, 10, 3);
        }
        public Palladin CreatePalladin()
        {
            return new Palladin(65, "Paladin", 10, 30, 5, 8);
        }
        public Cleric CreateCleric()
        {
            return new Cleric(75, "Cleric", 1, 15, 3);
        }
        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Energy right now: {Energy}.");
        }
    }
}
