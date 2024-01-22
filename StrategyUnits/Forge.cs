using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void WeaponUpgrade(MilitaryUnit unit)
        {
            if (unit.WeaponLvl < 2)
            {
                unit.WeaponLvl += 1;
                unit.Damage += 3;
                Console.WriteLine($"{unit.Name} улучшил свой меч на 1 уровень. Текущий урон: {unit.Damage}, текущий уровень меча {unit.WeaponLvl}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальный уровень меча: {unit.WeaponLvl}");
            }
        }
        public void ArmorUpgrade(Unit unit)
        {
            if (unit.ArmorLvl < 2)
            {
                unit.ArmorLvl += 1;
                unit.Protection += 3;
                Console.WriteLine($"{unit.Name} улучшил свою броню на 1 уровень. Текущая броня: {unit.Protection}, текущий уровень брони: {unit.ArmorLvl}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальный уровень брони: {unit.ArmorLvl}");
            }
        }
    }
}
