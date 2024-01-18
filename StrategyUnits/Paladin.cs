using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _damage;
        public Paladin(int mana, int Damage) : base (Damage, "Paladin", 55, mana)
        {
            _damage = Damage;
            _mana = mana;
            maxMana = mana;
        }
    }
}