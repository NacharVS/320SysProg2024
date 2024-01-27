using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Altar
    {
        //Magic units
        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", false, 12, 12, 20, 20, 3);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", false, 18,18,30,30,6,22);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", false, 8, 8, 35, 35, 5);
        }
    }
}
