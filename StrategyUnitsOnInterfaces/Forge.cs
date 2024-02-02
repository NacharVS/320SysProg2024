using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnitsOnInterfaces
{
    internal class Forge : Building
    {
        public void UpgradeArmor(params IBattleUnit[] units)
        {
            foreach (var unit in units)
            {
                if (unit.LevelArmor < 2)
                {
                    unit.LevelArmor += 1;
                    Console.WriteLine($"Герою {unit.GetType().Name} добавлен уровень брони!");
                }
                else
                {
                    Console.WriteLine($"У героя {unit.GetType().Name} максимальный уровень брони!");
                }
            }
        }
        public void UpgradeWeapon(params IBattleUnit[] units)
        {
            foreach (var unit in units)
            {
                if (unit.LevelWeapon < 2)
                {
                    unit.LevelWeapon += 1;
                    Console.WriteLine($"Герою {unit.GetType().Name} добавлен уровень оружия!");
                }
                else
                {
                    Console.WriteLine($"У героя {unit.GetType().Name} максимальный уровень оружия!");
                }
            }
        }
    }
}
