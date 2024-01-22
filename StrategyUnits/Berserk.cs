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

        public Berserk(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int v, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, v, nameOfUnit)
        {
            NameOfUnit = nameOfUnit;
        }

        public bool Rage
        {
            get
            {

                return _rage;
            }
        }
     

        public override void ShowInfo()
        {

            Console.WriteLine($"{NameOfUnit} - юнит {NameOfClass} класса \n" + $"Здоровье: {CurrentHealth}/{MaxHealth}\n" + $"Броня: {Defense}\n" + $"Состояние рейдж!!!: {Rage}\n" + $"Урон (Мин - Макс): {MinDamage} - {MaxDamage}\n");
        }

        public void RageOn()
        {

            if (CurrentHealth <= MaxHealth / 2 && _rage == false)
            {
                MinDamage *= 2;
                MaxDamage *= 2;
                _rage = true;
            }
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
