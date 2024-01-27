using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Berserker : Footman, IArmoredUnit
    {
        public int Protection { get; set; }
        private bool _rage = false;

        public Berserker(double currentHealth, bool isDied, double maxHealth, double damage) : base(currentHealth, isDied, maxHealth, damage)
        {
        }

        public bool Rage
        {
            get { return _rage; }
            set { _rage = value; }
        }


    }
}
