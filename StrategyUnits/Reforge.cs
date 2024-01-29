using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static StrategyUnits.Interfase.IAttack;
using static StrategyUnits.Interfase.IArmor;

namespace StrategyUnits
{
    internal class Reforge
    {
        public void UpdateWeapon()
        {
            if (IAttack.WeaponLvl < 3)
            {
                IAttack.WeaponLvl++;
                Console.WriteLine($"Уровень оружия вырос на 1. Нынешний уровень {IAttack.WeaponLvl}");
            }
            else
            {
                Console.WriteLine("Уровень оружия достиг максимального");
            }
        }
        public void UpdateArmor()
        {

            if (IArmor.ArmorLvl < 3)
            {
                IArmor.ArmorLvl++;
                Console.WriteLine($"Уровень брони вырос на 1. Нынешний уровень {IArmor.ArmorLvl}");
            }
            else
            {
                Console.WriteLine("Уровень брони достиг максимального");
            }
        }
    }
}
