using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void WeaponUpgrade()
        {
            
            if (IAttack.LvlWeapon < 2)
            {
                IAttack.LvlWeapon++;
            }
            else
            {
                Console.WriteLine($"Уже достигнут максимальный уровень оружия");
            }
        }
        public void ArmorUpgrade()
        {
            
            if (IProtection.LvlArmor < 2)
            {
                IProtection.LvlArmor ++;
            }
            else
            {
                Console.WriteLine($"Уже достигнут максимальный уровень брони");
            }
        }
    }
}
