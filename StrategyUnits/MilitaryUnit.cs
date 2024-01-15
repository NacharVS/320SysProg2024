﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
    }
}
