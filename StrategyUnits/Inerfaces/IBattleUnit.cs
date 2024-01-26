﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IBattleUnit
    {
        public double Damage { get; set; }
        public void Attack(IHealth currentHealth);
    }
}
