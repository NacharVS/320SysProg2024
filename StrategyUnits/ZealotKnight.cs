using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        private string _nameOfUnit;

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public ZealotKnight(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints)
        {
            _nameOfUnit = nameOfUnit;   
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

        public void Pray()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (IsDead)
            {
                Console.WriteLine("You can't heal a dead unit.\n");
                return;
            }
            int healthBeforeHeal = CurrentHealth;
            if (ManaPoints >= 10 && CurrentHealth < MaxHealth)
            {
                if (CurrentHealth + 20 <= MaxHealth)
                {
                    ManaPoints -= 10;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($">> Healed from {healthBeforeHeal} to {CurrentHealth + 20}. Mana left: {ManaPoints} MP.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    CurrentHealth += 20;
                }
                else
                {
                    ManaPoints -= 10;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($">> Healed from {healthBeforeHeal} to {MaxHealth}. Mana left: {ManaPoints} MP.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    CurrentHealth = MaxHealth;
                }
            }
            else if (this.ManaPoints < 10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("!!: Not enough mana left!\n");
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
    }
}
