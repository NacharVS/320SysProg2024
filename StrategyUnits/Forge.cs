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

                }
                else if (unit.LeverDamage == 1) //Второе
                {
                    unit.Damage += 2;
                    unit.LeverDamage = 2;
                }
                else
                    Console.WriteLine($"Повышения уровня атаки невозможно. {unit.Name} имеет максимальный уровень атаки.");

                UpgradeDamageEvent.Invoke(unit.Name, unit.LeverDamage, unit.Damage);
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

                }
                else if (unit.LeverArmor == 1) //Второе
                {
                    unit.MaxArmor += 2;
                    unit.LeverArmor = 2;
                }
                else
                    Console.WriteLine($"Повышения уровня атаки невозможно. {unit.Name} имеет максимальный уровень атаки.");

                UpgradeArmorEvent.Invoke(unit.Name, unit.LeverArmor, unit.MaxArmor);
            }
            else
                Console.WriteLine($"Улучшение невозможно. {unit.Name} мёртв.");

        }

        public event UpgradeDamageDelegate UpgradeDamageEvent;
        public event UpgradeArmorDelegate UpgradeArmorEvent;
    }
}
