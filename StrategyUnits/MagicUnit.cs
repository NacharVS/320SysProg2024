using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        private int _MaxManna;

        public int MaxManna
        {
          get { return _MaxManna; } 
          set { _MaxManna = value; }
        }
        public int Manna
        {
            get { return _manna; }
            set
            {
                if (value < 0)
                    _manna = 0;

                else
                    if (value > MaxManna)
                    _manna = MaxManna;
                else
                    _manna = value;
            }
        }
        public MagicUnit(int health, string? name, int damage, int MaxManna) : base(health, name, damage)
        {
            _manna = MaxManna;
            _MaxManna = MaxManna;
        }
    }
}
