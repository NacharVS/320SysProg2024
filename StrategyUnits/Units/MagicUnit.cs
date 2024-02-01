using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit, IMagicUnit
    {
        private int _manaPoints;
        private int _maxManaPoints;

        public int MaxManaPoints
        {
            get { return _maxManaPoints; }
            set { _maxManaPoints = value; }
        }

        public MagicUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage)
        {
            ManaPoints = manaPoints;
            MaxManaPoints = manaPoints;
        }

        public int ManaPoints
        {
            get { return _manaPoints; }
            set { _manaPoints = value; }
        }

        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage} \nManaPoints: {this.ManaPoints}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AttackMagically(IAttackedUnit unit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random rnd = new Random();
            int appliedDamage = rnd.Next(MinDamage, MaxDamage) - unit.Defense;
            if (!unit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    Console.WriteLine(
                        $">> Magic attack successful. You've applied {appliedDamage} ({appliedDamage + unit.Defense}-{unit.Defense}) DP. You've also lost {appliedDamage * 2} MP.\n"
                        );
                    unit.TakeDamage(appliedDamage);
                    TakeMana(appliedDamage*2);
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

        public void TakeMana(int manaPoints)
        {
            ManaPoints -= manaPoints;
        }

        public void AddMana(int manaPoints)
        {
            ManaPoints += manaPoints;
        }
    }
}
