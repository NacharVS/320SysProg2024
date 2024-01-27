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
        public Berserker(string? name, bool isDied, double currentHealth, double maxHealth, double damage, int protection) : base(name, isDied, currentHealth, maxHealth, damage)
        {
            Protection = protection;
        }
        //private bool _rage = false;
        //public bool Rage
        //{
        //    get { return _rage; }
        //    set { _rage = value; }
        //}


    }
}
