using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void UpgradeDamage()
        {
            if (IBattleUnit.LevelExtraDamage == 0)
            {
                IBattleUnit.ExtraDamage += 2;
                IBattleUnit.LevelExtraDamage++;
                Console.WriteLine($"Сделано первое улучшение атаки юнитов.");
                return;
            }
            if (IBattleUnit.LevelExtraDamage == 1)
            {
                IBattleUnit.ExtraDamage += 3;
                IBattleUnit.LevelExtraDamage++;
                Console.WriteLine($"Сделано второе улучшение атаки юнитов.");
            }
            else
            {
                Console.WriteLine($"Юниты имеют максимальное улучшение атаки. Больше нельзя улучшить");
            }
        }


        public void UpgradeArmor()
        {
            if (IArmoredUnit.LevelExtraArmor == 0)
            {
                IArmoredUnit.ExtraArmor += 2;
                IArmoredUnit.LevelExtraArmor++;
                Console.WriteLine($"Сделано первое улучшение защиты юнитов.");
                return;
            }
            if (IArmoredUnit.LevelExtraArmor == 1)
            {
                IArmoredUnit.ExtraArmor += 2;
                IArmoredUnit.LevelExtraArmor++;
                Console.WriteLine($"Сделано второе улучшение защиты юнитов.");
            }
            else
            {
                Console.WriteLine($"Юниты имеют максимальное улучшение защиты. Больше нельзя улучшить");
            }
        }
    }
}
