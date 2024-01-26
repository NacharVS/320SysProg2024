using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IHealer
    {
        public void HealSomebody(IHealth currentHealth);
    }
}
