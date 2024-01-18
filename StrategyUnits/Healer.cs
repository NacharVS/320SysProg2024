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
        public Healer(int Mana, int Health) : base(5, "Healer", Health, Mana)
        {
            _maxHealth = Health;
            _mana = Mana;
            maxMana = Mana;
        }
    }
}
