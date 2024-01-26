using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicAbilities
    {
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public double MagicDamage { get; set; }
        public void MagicAttack(IHealth unit);
        public void DecreaseEnergy(int energy);
        public void IncreaseEnergy(int energy);
    }
}
