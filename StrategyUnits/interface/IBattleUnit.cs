using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.@interface
{
    internal interface IBattleUnit
    {
        public int Damage { get; set; }

        public void InflictDamage(Unit unit);
    }
}
