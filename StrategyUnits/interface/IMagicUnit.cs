using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.@interface
{
    internal interface IMagicUnit
    {
        public int MaxMana { get; set; }
        public void Heal(Unit unit);

        public int Mana { get; set; }
    }
}
