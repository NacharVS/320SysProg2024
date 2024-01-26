using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IBattleUnit
    {
        public int Damage { get; set; }

        public void Attack(IHealth unit);
    }
}
