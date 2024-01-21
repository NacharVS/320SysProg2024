using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base(5, "Healer", 40, 55)
        {
            _maxHealth = Health;
            maxMana = MaxiMana;
        }
    }
}
