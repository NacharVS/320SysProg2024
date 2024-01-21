using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Weapon
    {
        public void WeaponUpgrade(MilitaryUnit militaryUnit)
        {
            if (militaryUnit.WeaponLvl < 2)
            {
                militaryUnit.WeaponLvl += 1;
                Console.WriteLine($"{militaryUnit.Name} upgrade weapon. Weapon's level {militaryUnit.WeaponLvl}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name}, weapon achieved maximal level: {militaryUnit.WeaponLvl}");
            }
        }
    }
}
