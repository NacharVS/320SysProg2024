using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _minDamage;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        private int _maxDamage;

        public MilitaryUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage) : base(currentHealth, nameOfClass, defense)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public virtual void Attack(Unit attackedUnit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random rnd = new Random();
            int appliedDamage = rnd.Next(this.MinDamage, this.MaxDamage) - attackedUnit.Defense;
            if (!attackedUnit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    Console.WriteLine(
                        $">> Attack successful. You've applied {appliedDamage} DP.\n"
                        );
                    attackedUnit.CurrentHealth -= appliedDamage;
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
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
