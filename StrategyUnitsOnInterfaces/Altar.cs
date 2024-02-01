using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Altar : Building
    {
        public Altar()
        {
            
        }
        public Cleric CreateCleric()
        {
            return new Cleric(20, 100);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(40, 120);
        }
        public void HealAltar(IMagicUnit unit)
        {
            while (unit.Mana < unit.MaxMana)
            {
                Energy -= 1;
                unit.Mana += 10;
            }
        }

    }
}
