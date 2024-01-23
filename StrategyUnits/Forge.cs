using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void LvlUpDamage(MilitaryUnit unit)
        {
            unit._damage += 2;
        }
        public void LvlUpArmor (Unit unit)
        {
            unit.Armor += 2;
        }
        public void LvlUpAttack2(MilitaryUnit unit)
        {
            unit._damage += 2;
        }
        public void LvlUpArmor2(Unit unit)
        {
            unit.Armor += 2;
        }
    }
}
