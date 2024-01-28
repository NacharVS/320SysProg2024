using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyUnits.Unit;

namespace StrategyUnits
{
    internal interface IHealth
    {
        public int PrevHealth {  get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public bool Dead { get; set; }
        public bool Rrage { get; set; }
        public int SuitHP { get; set; }

    }
}
