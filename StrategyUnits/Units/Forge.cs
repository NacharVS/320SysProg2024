using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Forge
    {
        public void UpdateWeapons()
        {
            if (IAttack.LvlWeapon < 2)
            {
                IAttack.LvlWeapon++;
            }
        }
        public void UpdateArmor()
        {
            if (IArmoredUnit.LvlArmor < 2)
            {
                IArmoredUnit.LvlArmor++;
            }
        }
    }
}
