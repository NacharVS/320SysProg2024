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
                Console.WriteLine($"{unit.Name} повысил уровень меча на 1. Текущий урон: {unit.Damage}, текущий уровень меча: {unit.WeaponLvl}\n");
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
                Console.WriteLine($"{unit.Name} повысил уровень щита на 1. Текущая защита: {unit.Protection}, текущий уровень щита: {unit.ArmorLvl}\n");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальный уровень щита: {unit.ArmorLvl}\n");
            }
        }
    }
}
