using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(string? name, int health, int minDamage, int maxDamage, int shield) : base(name, health, minDamage, maxDamage, shield)
        {

        }
    }
}
