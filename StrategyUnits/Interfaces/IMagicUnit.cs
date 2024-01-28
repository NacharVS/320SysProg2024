using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit
    {
        public int MaxiMana { get; set; }
        public int Mana {  get; set; }
        public int PrevMana { get; set; }
        public void ToHeal(Unit unit);
    }
}
