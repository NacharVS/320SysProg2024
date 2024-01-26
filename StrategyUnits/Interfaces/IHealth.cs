﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealth
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public void TakeDamage(int damage);
    }
}
