using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MillitaryUnit
    {
        private int _manna;
        public MagicUnit(int minDamage, int maxDamage, string? name, int Health) : base(minDamage, maxDamage, name, Health)
        {
            _manna = 40;
        }
        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }
    }
}
