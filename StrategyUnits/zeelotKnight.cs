﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class zeelotKnight : MagicUnit
    {
        public zeelotKnight(int health, string? name, bool active, int damage, int maxDamage, int mana, int armors, int lvlappArmor, int lvlappAttack) : base(health, name, active, damage, maxDamage,mana, armors, lvlappArmor, lvlappAttack) { }


        public void Prayer()
        {
            Health += 20;
            Mana -= 10;
        }
        
    }
}