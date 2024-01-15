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
        
        public MilitaryUnit(string? name, int health, int damage) : base(name, health) 
        {
            _damage = damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Damage: {Damage}");
        }

        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public virtual void Attack(Unit unit)
        {
            unit.Health -= _damage;
            Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name}");
        }
    }
}
