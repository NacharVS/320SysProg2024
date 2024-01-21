using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        public new int _mana;
        public new int _maxMana;
        public Paladin() : base(50, "Paladin", 10)
        {
            _mana = 30;
            _maxMana = _mana;
        }
    }
}
