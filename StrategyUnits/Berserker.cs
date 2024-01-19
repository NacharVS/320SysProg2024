using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : MillitaryUnit
    {
        public Berserker(int minDamage, int maxDamage, string? name, int Health, int protection) : base(minDamage, maxDamage, name, Health, protection)
        {
        }

        public override int MaxDamage
        {
            get { if (Health < MaxHealth * 0.5)
                    return _maxDamage * 2;
                else
                    return _maxDamage; }
            set { _maxDamage = value; }
        }
    }
}