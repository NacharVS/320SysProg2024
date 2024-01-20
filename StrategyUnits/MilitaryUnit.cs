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
        public MilitaryUnit(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {
            MinDamage = _minDamage;
            MaxDamage = _maxDamage;
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
            int appliedDamage = rnd.Next(MinDamage, MaxDamage) - attackedUnit.Defense;
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
            Console.WriteLine($"Unit: {NameOfClass} Health: {CurrentHealth} MaxHealth: {MaxHealth} \nDefense: {Defense} MinDamage: {MinDamage} MaxDamage: {MaxDamage}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
