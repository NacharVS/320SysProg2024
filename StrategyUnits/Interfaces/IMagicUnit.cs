using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    public interface IMagicUnit : IMagic
    {
        public void AttackMagically(IAttackedUnit unit);
    }
}
