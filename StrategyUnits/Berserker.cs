using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        internal bool _rage = false;

        public Berserker(string? name, int health, int minDamage, int maxDamage, int shield) : base(name, health, minDamage, maxDamage, shield)
        {

        }

        public override int MinDamage
        {
            get
            {
                if (_rage)
                {
                    return _minDamage + _minDamage / 2;
                }
                else
                {
                    return _minDamage;
                }
            }
            set
            {
                _minDamage = value;
            }
        }

        public override int MaxDamage
        {
            get
            {
                if (_rage)
                {
                    return _maxDamage + _maxDamage / 2;
                }
                else
                {
                    return _maxDamage;
                }
            }
            set
            {
                _maxDamage = value;
            }
        }
    }
}
