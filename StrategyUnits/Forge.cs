using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void UpgradeDamage(MillitaryUnit unit)
        {
            if (!unit.isAlive)
            {
                Console.WriteLine($"{unit.Name} is dead");
                return;
            }
            unit.MinDamage += 2;
            unit.MaxDamage += 2;
            unit.LevelArmor++;
        }
        public void UpgradeShield(MillitaryUnit unit)
        {
            if (!unit.isAlive)
            {
                Console.WriteLine($"{unit.Name} is dead");
                return;
            }
            unit.Protection += 2;
            unit.LevelArmor++;
        }
    }    
}

