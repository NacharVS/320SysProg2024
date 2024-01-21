using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void WeaponUpgreat(MilitaryUnit militaryUnit)
        {
            if(militaryUnit.Weapon < 3)
            {
                militaryUnit.Weapon += 1;
                Console.WriteLine($"{militaryUnit.Name} улучшил свое оружие. Уровень оружия {militaryUnit.Weapon}");
            }
            else
            {
                Console.WriteLine($"{militaryUnit.Name}, оружие имеет мактимальный уровень: {militaryUnit.Weapon}");
            }
        }

        public void ArmorUpgreat(MilitaryUnit militaryUnit)
        {
            if(militaryUnit.Armor < 4)
            {
                militaryUnit.Armor += 1;
                Console.WriteLine($"У игрока {militaryUnit.Name} броня уличшилась на один уровень: {militaryUnit.Armor}");
            }
            else
            {
                Console.WriteLine($"У игрока {militaryUnit.Name} броня на максимальном уровне: {militaryUnit.Armor}");
            }
        }
    }
}
