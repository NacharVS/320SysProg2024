using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _energy;

        private int _selfheal;
        public int SelfHeal
        {
            get { return _selfheal; }
            set { _selfheal = value; }
        }
        private int _healother;
        public int Healother
        {
            get { return _healother; }
            set { _healother = value; }
        }

        public Cleric() : base(60, "Cleric")
        {
           _energy = 100;
           _selfheal = 2;
           _healother= 1;
        }

        public void InflictHeal (Unit unit)
        {
            while (_energy > 0)
            {
               
                if (unit.Health >= MaxHealth)
                {
                    unit.Health = MaxHealth;
                }
                else if (unit.Health <= 0) 
                {
                    Console.WriteLine("Персонаж мертв! Лечить нельзя!");
                }
                else
                {
                    _energy -= 2;
                    unit.Health += _healother;
                }
                
            }
        }
    }
}
