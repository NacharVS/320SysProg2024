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
        public MagicUnit(int health, string? name, int armor, int damage, int maxdamage, int manna) : base(health, name, armor, damage, maxdamage)
        {
            _manna = manna;
            MaxManna = manna;
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