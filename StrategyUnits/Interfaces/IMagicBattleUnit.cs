using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicBattleUnit
    {
        
        public int MagicDamage { get; set; }
        public void MagicAttack(IHealth unit);
    }
}
