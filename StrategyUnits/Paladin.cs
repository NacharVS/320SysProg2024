using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _mana;
        private int _damage;
        public int maxMana;
        public int MaxiMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else
                    if (value > maxMana)
                    _mana = maxMana;
                else
                    _mana = value;
            }
        }
        public Paladin(int mana, int Damage) : base (Damage, "Paladin", 55, mana)
        {
            _damage = Damage;
            _mana = mana;
            maxMana = mana;
        }
        public override void InflictDamage(Unit unit)
        {
            base.InflictDamage(unit);
        }
    }
}