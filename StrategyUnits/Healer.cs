
using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private String _nameOfUnit;

        public String NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public Healer(String nameOfUnit) : base(40, "Healer", 1, 0, 2, 100)
        {
            nameOfUnit = _nameOfUnit;
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.IsDead == true)
            {
                Console.WriteLine("Unit is dead.");
                return;
            }
            while (this.ManaPoints > 0)
            {
                if(unit.CurrentHealth < unit.MaxHealth)
                {
                    this.ManaPoints -= 2;
                    Console.WriteLine($"Healed from {unit.CurrentHealth} to {unit.CurrentHealth + 1}; Mana left: {this.ManaPoints}");
                    unit.CurrentHealth++;
                }
                if (unit.CurrentHealth >= unit.MaxHealth)
                {
                    Console.WriteLine($"Healed successfully.");
                    break;
                }
                    
            }
            if (this.ManaPoints == 0)
            {
                Console.WriteLine("No mana left!");
            }   
        }

        public void Healself()
        {
            if (IsDead == true)
            {
                Console.WriteLine("Unit is dead.");
                return;
            }
            while (this.ManaPoints > 0)
            {
                if (CurrentHealth < MaxHealth)
                {
                    this.ManaPoints--;
                    int finalHealth = CurrentHealth + 2 >= MaxHealth ? MaxHealth : CurrentHealth + 2;
                    Console.WriteLine($"Healed from {CurrentHealth} to {finalHealth}; Mana left: {this.ManaPoints}");
                    CurrentHealth += 2;
                }
                if (CurrentHealth >= MaxHealth)
                {
                    Console.WriteLine($"Healed successfully.");
                    break;
                }
            }
            if (ManaPoints == 0)
            {
                Console.WriteLine("No mana left!");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {NameOfUnit}\nUnit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage} \nManaPoints: {this.ManaPoints}");
        }
    }
}
