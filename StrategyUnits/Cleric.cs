using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric() : base(15, "Cleric", 1, 15)
        {

        }

        public void HealSelf(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
                Console.WriteLine($"{unit.Name} умер, восстановить здоровье нельзя");
                return;
            }
            while (CurrentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                unit.CurrentHealth += 2;
                CurrentEnergy -= 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HealSomebody(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{unit.Name} умер, восстановить здоровье нельзя");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            while (CurrentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                if (CurrentEnergy < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Недостаточно энергии для проведения лечения {unit.Name} не хватает 1 очка");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                unit.CurrentHealth += 1;
                CurrentEnergy -= 2;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{unit.Name} исцелился с {healthBeforeHealth} до {unit.CurrentHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.Name} Health: {this.CurrentHealth} Energy: {this.CurrentEnergy}");
        }
    }
}
