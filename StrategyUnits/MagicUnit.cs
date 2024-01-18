using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        public event HealthChangedDelegate ClericHeal;
        private int _manna;
        public int MaxManna { get; private set; }
        public MagicUnit(int health, string? name) : base(health, name)
        {
        }
        public int Manna
        {
            get { return _manna; }
            set
            {
                if (value < 0)
                {
                    _manna = 0;
                }
                else if (value > MaxManna)
                {
                    _manna = MaxManna;
                }
                else
                {
                    _manna = value;
                }
            }
        }
    }
}
