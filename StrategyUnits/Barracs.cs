using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class Barracs // class factory
    {
        
        public MilitaryUnit CreateFootman()
        {
            return new MilitaryUnit(60, "Footman", 6, 7, 10);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(120, "Berserker", 4, 10, 20);
        }
        public MagicUnit CreateCleric()
        {
            return new Cleric(50, "Cleric", 5, 8, 12, 40);
        }
        public Unit CreatePeasent()
        {
            return new Peasant(30, "Peasant", 0);
        }
        public MagicUnit CreatePaladin()
        {
            return new Paladin(70, "Paladin", 5, 7, 10, 40);
        }
        public MagicUnit CreateZeelotKnight()
        {
            return new ZeelotKnight(40, "Zeelot Knight", 5, 8, 10, 60);
        }
    }
}
