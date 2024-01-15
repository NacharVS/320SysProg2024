﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public MilitaryUnit(int maxHealth, string? name, int damage) : base(maxHealth, name)
        {
            _damage = damage;
        }

        public virtual void InflictDamage(Unit unit)
        {
            if (unit.Life)
            {
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine($"Персонаж {unit.Name} мертв");
            }
        }
    }
}
