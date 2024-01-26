using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMilitaryUnit
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public void Attack(IHealth unit);
    }
}
