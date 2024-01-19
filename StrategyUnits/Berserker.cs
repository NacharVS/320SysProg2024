using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        internal bool _rageActive = false;
        public Berserker(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield)
        {
        }

        public override int MaxDamage
        {
            get
            {
                if (_rageActive)
                    return _maxDamage + _maxDamage / 2;
                else
                    return _maxDamage;
            }
            set { _maxDamage = value; }
        }

        public override int MinDamage
        {
            get 
            {
                if (_rageActive)
                    return _minDamage + _minDamage / 2;
                else
                    return _minDamage; 
            }
            set { _minDamage = value; }
        }

    }
}
