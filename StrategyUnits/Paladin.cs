using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        public Paladin() : base("Paladin", 11, 50, 50)
        {
            maxMana = _mana;
        }
    }
}