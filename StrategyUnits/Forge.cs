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
                Console.WriteLine($"{unit.Name} improved sword by 1 level. Current damage: {unit.Damage}, current sword level: {unit.WeaponLvl}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} has maximum sword level: {unit.WeaponLvl}");
            }
        }
        public void ArmorUpgrade(Unit unit)
        {
            if (unit.ArmorLvl < 2)
            {
                unit.ArmorLvl += 1;
                unit.Protection += 3;
                Console.WriteLine($"{unit.Name} improved armor by 1 level. Current protection: {unit.Protection}, current armor level: {unit.ArmorLvl}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} has maximum armor level: {unit.ArmorLvl}");
            }
        }
    }
}
