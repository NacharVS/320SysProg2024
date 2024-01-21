using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        private bool _holyArmor;
        public bool HolyArmor
        {
            get
            {

                return _holyArmor;
            }
        }
        private string _nameOfUnit;

        public Paladin(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints, nameOfUnit)
        {
            NameOfUnit = nameOfUnit;
        }

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

         public override void AttackMagically(Unit attackedUnit)
        {
            Random rnd = new Random();
            int appliedDamage = rnd.Next(this.MinDamage*2, this.MaxDamage*2) - attackedUnit.Defense/2;
            if (!attackedUnit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    if (this.ManaPoints > appliedDamage)
                    {
                        this.ManaPoints -= appliedDamage * 3;
                        Console.WriteLine($">> Magic attack successful. You've applied {appliedDamage} MDP.\n");
                        attackedUnit.CurrentHealth -= appliedDamage;
                    }
                    else
                    {
                        Console.WriteLine(">> Attack didn't succeed. You have no enough mana for this attack.\n");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(">> No damage applied.\n");
                }
            }
            else
            {
                Console.WriteLine("Unit is already dead. Stop beating a dead body!\n");
            }
        }

        public void HolyArmorOn()
        {
            if (CurrentHealth <= MaxHealth / 2 && _holyArmor == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($">> Paladin {this.NameOfUnit} was blessed with holy armor!\n");
                Defense *= 2;
                _holyArmor = true;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void HolyArmorOff()
        {
            if (CurrentHealth > MaxHealth / 2 && _holyArmor == true)
            {
                Defense /= 2;
                _holyArmor = false;
            }
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
