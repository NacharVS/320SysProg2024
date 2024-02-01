using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMilitaryUnit
    {
        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public void Attack(IAttackedUnit unit);
    }
}
