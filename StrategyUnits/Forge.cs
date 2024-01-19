using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void UpgradeDamage(MilitaryUnit unit)
        {
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Он не может посетить кузницу");
                return;
            }
            if (unit._levelDamage == 0)
            {
                unit.MinDamage += 2;
                unit.MaxDamage += 2;
                unit._levelDamage++;
                Console.WriteLine($"{unit.Name} сделал первое улучшение атаки. Текущая атака: {unit.MinDamage}-{unit.MaxDamage}");
                return;
            }
            if (unit._levelDamage == 1)
            {
                unit.MinDamage += 3;
                unit.MaxDamage += 3;
                unit._levelDamage++;
                Console.WriteLine($"{unit.Name} сделал второе улучшение атаки. Текущая атака: {unit.MinDamage}-{unit.MaxDamage}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальное улучшение атаки. Больше нельзя улучшить");
            }
        }


        public void UpgradeShield(MilitaryUnit unit)
        {
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Он не может посетить кузницу");
                return;
            }
            if (unit._levelShield == 0)
            {
                unit.Shield += 2;
                unit._levelShield++;
                Console.WriteLine($"{unit.Name} сделал первое улучшение защиты. Текущая защита: {unit.Shield}");
                return;
            }
            if (unit._levelShield == 1)
            {
                unit.Shield += 2;
                unit._levelShield++;
                Console.WriteLine($"{unit.Name} сделал второе улучшение защиты. Текущая защита: {unit.Shield}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальное улучшение защиты. Больше нельзя улучшить");
            }
        }
    }
}
