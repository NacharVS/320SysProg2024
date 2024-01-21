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
