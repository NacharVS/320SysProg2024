using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric(double health, string? name, double damage, double maxEnergy, double protection) : base(health, name, damage, maxEnergy, protection)
        {
        }

        public void HealSomebody(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
<<<<<<< Updated upstream
=======
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{unit.Name} умер. Его нельзя вылечить");
                Console.ForegroundColor = ConsoleColor.White;
>>>>>>> Stashed changes
                return;
            }
            while (CurrentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    return;
                }
                if (CurrentEnergy < 2)
                {
                    break;
                }
                unit.CurrentHealth += 1;
                CurrentEnergy -= 2;
            }
<<<<<<< Updated upstream
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.Name} Health: {this.CurrentHealth} Energy: {this.CurrentEnergy}");
=======
>>>>>>> Stashed changes
        }

        //public void HealSelf(Unit unit)
        //{
        //    var healthBeforeHealth = unit.CurrentHealth;
        //    if (unit.IsDied)
        //    {
        //        Console.WriteLine($"{unit.Name} умер, восстановить здоровье нельзя");
        //        return;
        //    }
        //    while (CurrentEnergy > 0)
        //    {
        //        if (unit.MaxHealth <= unit.CurrentHealth)
        //        {
        //            return;
        //        }
        //        unit.CurrentHealth += 2;
        //        CurrentEnergy -= 1;
        //    }
        //}
    }
}
