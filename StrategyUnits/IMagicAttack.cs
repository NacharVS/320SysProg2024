using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicAttack
    {
        public void MagicAttack (IHealth unit);
        public int MagicDamage { get; set; }
    }
}
