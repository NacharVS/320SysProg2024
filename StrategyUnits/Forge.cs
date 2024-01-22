using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Forge //Кузница - увеличивает показатели урона и защиты на 2 с каждым уровнем. Максимальный уровень: 2.
    {
        public delegate void UpgradeDamageDelegate(string? name, int lever, int damage);
        public delegate void UpgradeArmorDelegate(string? name, int lever, int armor);
        public void UpgradeDamage(MilitaryUnit unit) //Улучшение Урона
        {
            if (unit.IsDead == false)
            {
                if (unit.LeverDamage == 0) //Первое улучшение
                {
                    unit.Damage += 2;
                    unit.LeverDamage = 1;
                    Console.WriteLine($"{unit.Name} улучшил уровень атаки. \tТекущая атака: {unit.Damage} уровня {unit.LeverDamage}");

                }
                else if (unit.LeverDamage == 1) //Второе
                {
                    unit.Damage += 2;
                    unit.LeverDamage = 2;
                    Console.WriteLine($"{unit.Name} улучшил уровень атаки. \tТекущая атака: {unit.Damage} уровня {unit.LeverDamage}");
                }
                else
                    Console.WriteLine($"Повышения уровня атаки невозможно. {unit.Name} имеет максимальный уровень атаки.");

                //UpgradeDamageEvent.Invoke(unit.Name, unit.LeverDamage, unit.Damage);
            }
            else
                Console.WriteLine($"Улучшение невозможно. {unit.Name} мёртв.");

        }

        public void UpgradeArmor(MilitaryUnit unit) //Улучшение Урона
        {
            if (unit.IsDead == false)
            {
                if (unit.LeverArmor == 0) //Первое улучшение
                {
                    unit.MaxArmor += 2;
                    unit.LeverArmor = 1;
                    Console.WriteLine($"{unit.Name} улучшил уровень защиты. \tТекущая защита: {unit.Armor} уровня {unit.LeverArmor}");

                }
                else if (unit.LeverArmor == 1) //Второе
                {
                    unit.MaxArmor += 2;
                    unit.LeverArmor = 2;
                    Console.WriteLine($"{unit.Name} улучшил уровень защиты. \tТекущая защита: {unit.Armor} уровня {unit.LeverArmor}");
                }
                else
                    Console.WriteLine($"Повышения уровня защиты невозможно. {unit.Name} имеет максимальный уровень защиты.");

                //UpgradeArmorEvent.Invoke(unit.Name, unit.LeverArmor, unit.MaxArmor);
            }
            else
                Console.WriteLine($"Улучшение невозможно. {unit.Name} мёртв.");

        }

        public event UpgradeDamageDelegate UpgradeDamageEvent;
        public event UpgradeArmorDelegate UpgradeArmorEvent;
    }
}
