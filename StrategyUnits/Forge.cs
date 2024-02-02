using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        public void DamageUpgrade()
        {
            if (IBattleUnit.LevelExtraDamage < 2)
            {
                IBattleUnit.ExtraDamage += 2;
                IBattleUnit.LevelExtraDamage++;
                Console.WriteLine($"Сделано улучшение атаки юнитов");
            }
            else
            {
                Console.WriteLine($"Сделано максимальное улучшение атаки юнитов");
            }
        }

        public void ArmorUpgrade()
        {
            if (IArmoredUnit.LevelExtraArmor < 2)
            {
                IArmoredUnit.ExtraArmor += 2;
                IArmoredUnit.LevelExtraArmor++;
                Console.WriteLine($"Сделано улучшение защиты юнитов");
            }
            else
            {
                Console.WriteLine($"Сделано максимальное улучшение защиты юнитов");
            }
        }
    }
}
