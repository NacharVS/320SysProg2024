﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal interface IMagicUnit
    {
        public int Mana { get; set; }
        public int MaxMana { get; set;}
    }
}