using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class HogwartsBarracs
    {
        public MagicUnit CreateCliric()
        {
            return new MagicUnit(80, "Clirc", true, 1, 3, 60, 5, 0, 0);
        }
        public MagicUnit CreateZeelotKnight()
        {
            return new MagicUnit(70, "Zeelot knight", true, 2, 5, 70, 4, 0, 0);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(90, "Paladin", true, 6, 15, 45, 5, 0, 0);
        }
    }
}
