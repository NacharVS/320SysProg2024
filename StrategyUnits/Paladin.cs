using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(50, "Paladin")
        {
            Damage = 10;
            Mana = 50;
        }
    }
}
