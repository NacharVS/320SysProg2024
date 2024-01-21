using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void WeapomUpgrade(MilitaryUnit militaryUnit)
        {
            if (militaryUnit._levelDamage < 2)
            {
                militaryUnit._levelDamage += 1;
                militaryUnit.MinDamage += 1;
                militaryUnit.MaxDamage += 1;
                Console.WriteLine($"{militaryUnit.Name} улучшил своё оружие на 1 уровень. Уровень оружия - {militaryUnit._levelDamage}, урон - {militaryUnit.MinDamage}-{militaryUnit.MaxDamage}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name} имеет максимальный уровень оружия");
            }
        }

        public void ArmorUpgrade(MilitaryUnit militaryUnit)
        {
            if (militaryUnit._levelShield < 2)
            {
                militaryUnit._levelShield += 1;
                militaryUnit.Shield += 1;
                Console.WriteLine($"{militaryUnit.Name} улучшил свою броню на 1 уровень. Уровень брони - {militaryUnit._levelShield}, броня - {militaryUnit.Shield}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name} имеет максимальный уровень брони");
            }
        }
    }
}
