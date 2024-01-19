using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        private bool isRage = false;

        public bool IsRage
        {
            get { return isRage; }
            set { isRage = value; }
        }
        public Berserker(int health, string? name, int damage, int protection) : base(health, name, damage, protection)
        {
        }
    }
}
