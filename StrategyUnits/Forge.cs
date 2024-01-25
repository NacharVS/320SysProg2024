using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {

        public void AttackUpgrade(MilitaryUnit militaryUnit)
        {
            if (militaryUnit._levelDamage < 3)
            {
                militaryUnit._levelDamage += 1;
                militaryUnit.Damage += 1;
                Console.WriteLine($"{militaryUnit.Name} повысил атаку на 1 уровень. Уровень оружия - {militaryUnit._levelDamage}, урон - {militaryUnit.Damage}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name} имеет максимальный уровень оружия");
            }
        }

        public void ArmorUpgrade(MilitaryUnit militaryUnit)
        {
            if (militaryUnit._levelArmor < 3)
            {
                militaryUnit._levelArmor += 1;
                militaryUnit.Armor += 1;
                Console.WriteLine($"{militaryUnit.Name} улучшил свою броню на 1 уровень. Уровень брони - {militaryUnit._levelArmor}, броня - {militaryUnit.Armor}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name} имеет максимальный уровень брони");
            }
        }

    }
}
