using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.@interface
{
    internal interface IHealth
    {
        public int MaxHealth { get; set; }
        public int PravHealth { get; set; }
        public bool Dead { get; set; }
        public int CurentHealth { get; set; }

        public bool Rage { get; set; }


    }
}
