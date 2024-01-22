using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void UpdateLevelWeapon(MilitaryUnit unit)
        {
            if (unit.LevelWeapon < 2)
            {
                unit.LevelWeapon += 1;
                unit.Damage += 2;
                Console.WriteLine($"{unit.Name} make better his weapon on 1 level. Damage became: {unit.Damage}, Weapon level right now: {unit.LevelWeapon}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} max level weapon: {unit.LevelWeapon}");
            }
        }
        public void UpdateLevelArmor(Unit unit)
        {
            if (unit.LevellArmor < 2)
            {
                unit.LevellArmor += 1;
                unit.Guard += 2;
                Console.WriteLine($"{unit.Name} make his guard better on 1 level. Armor: {unit.Guard}, Level right now: {unit.LevellArmor}");
            }
            else
            {
                Console.WriteLine($"{unit.Name} has max level: {unit.LevellArmor}");
            }
        }
    }
}
