using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit : IMagical
    {
        public void MagicAttack(IAttackedUnit unit);
    }
}
