using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Forge //Кузница - увеличивает показатели урона и защиты на 2 с каждым уровнем. Максимальный уровень: 2.
    {
        public void UpgradeDamage() //Улучшение Урона
        {

            if (IInflictDamage.LevelWeapon == 0) //Первое улучшение
            {
                IInflictDamage.LevelWeapon += 1;
                Console.WriteLine($"Улучшение уровеня атаки. Текущий уровень: {IInflictDamage.LevelWeapon}");

            }
            else if (IInflictDamage.LevelWeapon == 1) //Второе
            {
                IInflictDamage.LevelWeapon += 1;
                Console.WriteLine($"Улучшение уровеня атаки. Текущий уровень: {IInflictDamage.LevelWeapon}");
            }
            else
                Console.WriteLine($"Повышения уровня атаки невозможно. Максимальный уровень");
        }

        public void UpgradeArmor() //Улучшение Урона
        {

            if (IArmor.LevelArmor == 0) //Первое улучшение
            {
                IArmor.LevelArmor += 1;
                Console.WriteLine($"Улучшение уровеня атаки. Текущий уровень: {IArmor.LevelArmor}");

            }
            else if (IArmor.LevelArmor == 1) //Второе
            {
                IArmor.LevelArmor += 1;
                Console.WriteLine($"Улучшение уровеня атаки. Текущий уровень: {IArmor.LevelArmor}");
            }
            else
                Console.WriteLine($"Повышения уровня атаки невозможно. Максимальный уровень");
        }

        //public void UpgradeArmor(MilitaryUnit unit) //Улучшение Урона
        //{
        //    if (unit.IsDead == false)
        //    {
        //        if (unit.LeverArmor == 0) //Первое улучшение
        //        {
        //            unit.MaxArmor += 2;
        //            unit.LeverArmor = 1;
        //            Console.WriteLine($"{unit.Name} улучшил уровень защиты. \tТекущая защита: {unit.Armor} уровня {unit.LeverArmor}");

        //        }
        //        else if (unit.LeverArmor == 1) //Второе
        //        {
        //            unit.MaxArmor += 2;
        //            unit.LeverArmor = 2;
        //            Console.WriteLine($"{unit.Name} улучшил уровень защиты. \tТекущая защита: {unit.Armor} уровня {unit.LeverArmor}");
        //        }
        //        else
        //            Console.WriteLine($"Повышения уровня защиты невозможно. {unit.Name} имеет максимальный уровень защиты.");

        //        //UpgradeArmorEvent.Invoke(unit.Name, unit.LeverArmor, unit.MaxArmor);
        //    }
        //    else
        //        Console.WriteLine($"Улучшение невозможно. {unit.Name} мёртв.");

        //}



    }
}
