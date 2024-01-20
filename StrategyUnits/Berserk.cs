using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : MilitaryUnit
    {

        private bool _rage;
        public bool Rage
        {
            get
            {

                return _rage;
            }
        }
        public Berserk(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {

        }
        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"====== CHARACTER ========\n" +
                $"{NameOfUnit} - a unit of {NameOfClass} class\n" +
               $"Health: {CurrentHealth}/{MaxHealth}\n" +
               $"Defense: {Defense}\n" +
               $"Is raged: {Rage}\n" +
               $"Damage (min - max): {MinDamage} - {MaxDamage}\n" +
               $"====== ========= ========\n");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void RageOn()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($">> Berserk {NameOfUnit} is now raging!\n");
            if (CurrentHealth <= MaxHealth / 2 && _rage == false)
            {
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
