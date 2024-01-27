using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IMagicAttack
    {
        public void MagicAttack(IHealth unit);
        public double MagicDamage { get; set; }
    }
}
