using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        private bool _rage;
        public bool Rage
        {
            get {
                
                return _rage;
            }
        }

        private string _nameOfUnit;

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public Berserk(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, nameOfUnit)
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
               $"Is raged: {Rage}\n" +
               $"Damage (min - max): {MinDamage} - {MaxDamage}\n" +
               $"====== ========= ========\n") ;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void RageOn()
        {
            if (CurrentHealth <= MaxHealth / 2 && _rage == false)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($">> Berserk {this.NameOfUnit} is now raging!\n");
                MinDamage *= 2;
                MaxDamage *= 2;
                _rage = true;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void RageOff()
        {
            if (CurrentHealth > MaxHealth / 2 && _rage == true)
            {
                MinDamage /= 2;
                MaxDamage /= 2;
                _rage = false;
            }
        }
    }
}
