
using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private string _nameOfUnit;

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public Healer(string nameOfUnit) : base(40, "Healer", 1, 0, 4, 100)
        {
            _nameOfUnit = nameOfUnit;
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.IsDead)
            {
                Console.WriteLine("You can't heal a dead unit.\n");
                return;
            }
            while (this.ManaPoints > 0)
            {
                if(unit.CurrentHealth < unit.MaxHealth)
                {
                    this.ManaPoints -= 2;
                    Console.WriteLine($">> Healed from {unit.CurrentHealth} to {unit.CurrentHealth + 1}. Mana left: {this.ManaPoints} MP.\n");
                    unit.CurrentHealth++;
                }
                if (unit.CurrentHealth >= unit.MaxHealth)
                {
                    Console.WriteLine($">> Healed successfully.\n");
                    break;
                }
                    
            }
            if (this.ManaPoints == 0)
            {
                Console.WriteLine("!!: No mana left!\n");
            }
        }

        public void Healself()
        {
            if (IsDead)
            {
                Console.WriteLine("You can't heal a dead unit.");
                return;
            }
            while (this.ManaPoints > 0)
            {
                if (CurrentHealth < MaxHealth)
                {
                    this.ManaPoints--;
                    int finalHealth = CurrentHealth + 2 >= MaxHealth ? MaxHealth : CurrentHealth + 2;
                    Console.WriteLine(
                        $">> Healed from {CurrentHealth} to {finalHealth}. Mana left: {this.ManaPoints}.\n"
                        );
                    CurrentHealth += 2;
                }
                if (CurrentHealth >= MaxHealth)
                {
                    Console.WriteLine($">> Healed successfully.\n");
                    break;
                }
            }
            if (ManaPoints == 0)
            {
                Console.WriteLine("!!:  No mana left!\n");
            }
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"====== CHARACTER ========\n" +
                $"{NameOfUnit} - a unit of {this.NameOfClass} class\n" +
               $"Health: {this.CurrentHealth}/{MaxHealth}\n" +
               $"Defense: {this.Defense}\n" +
               $"Damage (min - max): {this.MinDamage} - {this.MaxDamage}\n" +
               $"ManaPoints: {ManaPoints}\n" +
               $"====== ========= ========\n");
        }
    }
}
