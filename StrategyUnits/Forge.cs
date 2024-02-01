using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Extra;

namespace StrategyUnits
{
    internal class Forge
    {
        public void WeaponUpgrade()
        {
            if (IBattleUnit.WeaponLvl < 2)
            {
                IBattleUnit.WeaponLvl += 1;
                footman.Damage += 3;
                Console.WriteLine($"{footman.Name} повысил уровень меча на 1. Текущий урон: {footman.Damage}, текущий уровень меча: {footman.WeaponLvl}.\n");
            }
            else
            {
                Console.WriteLine($"{footman.Name} имеет максимальный уровень меча: {footman.WeaponLvl}.\n");
            }
        }
        public void ArmorUpgrade(Unit unit)
        {
            if (unit.ArmorLvl < 2)
            {
                unit.ArmorLvl += 1;
                unit.Protection += 3;
                Console.WriteLine($"{unit.Name} повысил уровень щита на 1. Текущая защита: {unit.Protection}, текущий уровень щита: {unit.ArmorLvl}.\n");
            }
            else
            {
                Console.WriteLine($"{unit.Name} имеет максимальный уровень щита: {unit.ArmorLvl}.\n");
            }
        }
    }
}
