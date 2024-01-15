using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private string _nameOfUnit;

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public Paladin(string nameOfUnit) : base(80, "Paladin", 5, 2, 12, 50)
        {
            NameOfUnit = nameOfUnit;
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
