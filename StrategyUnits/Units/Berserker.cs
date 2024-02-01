using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Berserker : Footman
    {
        private bool isRage = false;

        public bool IsRage
        {
            get { return isRage; }
            set
            {
                if (isRage == false && CurrentHealth == CurrentHealth / 2)
                {
                    Damage *= 1.5;
                    isRage = true;
                }
            }
        }
        public Berserker(double health, string? name, double damage, double protection) : base(health, name, damage, protection)
        {

        }
    }
}
