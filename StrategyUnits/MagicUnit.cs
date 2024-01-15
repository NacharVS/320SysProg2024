using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        public MagicUnit(int manna, int damage, int maxDamage, int Health, string? name) : base(damage, maxDamage, Health, name)
        {
            _manna = manna;
        }
        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }
        
    }
}
