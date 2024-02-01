using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    public class MilitaryUnit : Unit, IMilitaryUnit, IAttackedUnit
    {
        private int _minDamage;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        private int _maxDamage;

        public MilitaryUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage) : base(currentHealth, nameOfClass)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Defense = defense;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        private int _defense;

        public int Defense {
            get { return _defense; }
            set { _defense = value; }
        }

        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Attack(IAttackedUnit unit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random rnd = new Random();
            int appliedDamage = rnd.Next(MinDamage, MaxDamage) - unit.Defense;
            if (!unit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    Console.WriteLine(
                        $">> Attack successful. You've applied {appliedDamage} ({appliedDamage + unit.Defense}-{unit.Defense}) DP.\n"
                        );
                    unit.TakeDamage(appliedDamage);
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
    }
}
