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
        private int _minDamage;
        private int _maxDamage;

        public Berserker(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int armor) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, armor)
        {
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
    }
}
