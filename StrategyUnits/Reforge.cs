using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Reforge
    {
        public void UpdateWeapon(IAttack Unit)
        {
            if (Unit.WeaponLvl < 3)
            {
                Unit.Damage += 5;
                Unit.WeaponLvl++;
                Console.WriteLine($"Уровень оружия вырос на 1. Нынешний уровень {Unit.WeaponLvl}");
            }
            else
            {
                Console.WriteLine("Уровень оружия достиг максимального");
            }
        }
        public void UpdateArmor(IArmor Unit)
        {

            if (Unit.ArmorLvl < 3)
            {
                Unit.Defense += 3;
                Unit.ArmorLvl++;
                Console.WriteLine($"Уровень брони вырос на 1. Нынешний уровень {Unit.ArmorLvl}");
            }
            else
            {
                Console.WriteLine("Уровень брони достиг максимального");
            }
        }
    }
}
