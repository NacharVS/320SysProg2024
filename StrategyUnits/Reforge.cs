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
        public void UpdateWeapon(MilitaryUnit militaryUnit)
        {
            if (militaryUnit.Alive)
            {
                if (militaryUnit.WeaponLvl <= 3)
                {
                    militaryUnit.Damage += 5;
                    militaryUnit.WeaponLvl++;
                    Console.WriteLine($"Уровень оружия вырос на 1. Нынешний уровень {militaryUnit.WeaponLvl}");
                }
                else
                {
                    Console.WriteLine("Уровень оружия достиг максимального");
                }
            }
            else
                Console.WriteLine($"{militaryUnit.Name} мертв, он не может улучшить оружие");

        }
        public void UpdateArmor(MilitaryUnit militaryUnit)
        {
            if (militaryUnit.Alive)
            {
                if (militaryUnit.ArmorLvl <= 3)
                {
                    militaryUnit.Defense += 3;
                    militaryUnit.ArmorLvl++;
                    Console.WriteLine($"Уровень брони вырос на 1. Нынешний уровень {militaryUnit.ArmorLvl}");
                }
                else
                {
                    Console.WriteLine("Уровень брони достиг максимального");
                }
            }
            else
                Console.WriteLine($"{militaryUnit.Name} мертв, он не может улучшить броню");
        }

    }
}
