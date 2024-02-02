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
                Console.WriteLine($"Уровень меча повышен на 1 единицу.\n");
            }
            else
            {
                Console.WriteLine($"Максимальный уровень меча.\n");
            }
        }
        public void ArmorUpgrade()
        {
            if (IArmoredUnit.ArmorLvl < 2)
            {
                IArmoredUnit.ArmorLvl += 1;
                Console.WriteLine($"Уровень щита повышен на 1 единицу.\n");
            }
            else
            {
                Console.WriteLine($"Максимальный уровень щита.\n");
            }
        }
    }
}
