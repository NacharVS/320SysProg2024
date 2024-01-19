using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric(int health, string? name, int damage, int maxEnergy, int protection) : base(health, name, damage, maxEnergy, protection)
        {
        }

        public void HealSomebody(Unit unit)
        {
            var healthBeforeHealth = unit.CurrentHealth;
            if (unit.IsDied)
            {
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
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.Name} Health: {this.CurrentHealth} Energy: {this.CurrentEnergy}");
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
