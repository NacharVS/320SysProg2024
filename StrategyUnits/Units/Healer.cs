
using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private string _nameOfUnit;

        public Healer(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints)
        {
            _nameOfUnit = nameOfUnit;
        }

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }
        public void HealSomebody(Unit unit)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (unit.IsDead)
            {
                Console.WriteLine("You can't heal a dead unit.\n");
                return;
            }
            int healthBeforeHeal = unit.CurrentHealth;
            int healthToHeal = unit.MaxHealth - unit.CurrentHealth;
            int manaToSpend = healthToHeal * 2;

            if (this.ManaPoints > 0 && unit.CurrentHealth < unit.MaxHealth)
            {
                if (manaToSpend <= ManaPoints)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($">> Healed from {healthBeforeHeal} to {unit.CurrentHealth + healthToHeal}. Mana left: {this.ManaPoints - manaToSpend} MP.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    unit.CurrentHealth += healthToHeal;
                    TakeMana(manaToSpend);
                }
                else
                {
                    int lackOfMana = manaToSpend - ManaPoints;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($">> Healed from {healthBeforeHeal} to {unit.CurrentHealth + (manaToSpend - lackOfMana) / 2}. Mana left: {0} MP.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    unit.GetHeal((manaToSpend - lackOfMana) / 2);
                    ManaPoints = 0;
                }  
            }
            else if (this.ManaPoints == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("!!: No mana left!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (CurrentHealth == MaxHealth)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("!!: You don't need any heal!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Healself()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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
                    GetHeal(2);
                }
                if (CurrentHealth >= MaxHealth)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($">> Healed successfully.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
            if (ManaPoints == 0)
            {
                Console.WriteLine("!!:  No mana left!\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"====== CHARACTER ========\n" +
                $"{NameOfUnit} - a unit of {this.NameOfClass} class\n" +
               $"Health: {this.CurrentHealth}/{MaxHealth}\n" +
               $"Defense: {this.Defense}\n" +
               $"Damage (min - max): {this.MinDamage} - {this.MaxDamage}\n" +
               $"ManaPoints: {ManaPoints}\n" +
               $"====== ========= ========\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
