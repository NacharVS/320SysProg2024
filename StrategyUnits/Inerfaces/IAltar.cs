using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IAltar
    {
        public void RecoveryEnergy(IMagicAbilities currentEnergy);
        public void RestoreEnergy();

    }
}
