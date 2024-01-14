﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _manna;
        public Cleric() : base(30, "Cleric")
        {
            _manna = 40;
        }
        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public void selfHeal()
        {
            Console.WriteLine($"{Name} selfheal");
            while (Manna >= 1)
            {
                Health += 2;
                Manna -= 1;
            }
        }

        public void Heal(Unit unit)
        {
            if (unit.isAlive)
            {
                if (unit.Health == unit.MaxHealth)
                {
                    Console.WriteLine($"{Name} can't heal {unit.Name}, because health is full");
                }
                else
                {
                    Console.WriteLine($"{Name} heal {unit.Name}");
                    while (Manna >= 2 && (unit.Health < unit.MaxHealth))
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{Name} can't heal {unit.Name}");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Manna: {Manna}");
        }
    }
}