using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnitsOnInterfaces
{
    internal class Cleric : Unit, IMagicUnit
    {
        public Cleric(int health) : base(health)
        {
        }

        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public void Heal(Unit unit)
        {
            if (unit.IsAlive)
            {
                if (unit.Health == unit.MaxHealth)
                {
                    Console.WriteLine($"Cleric can't heal {unit.GetType().Name}, because health is full");
                }
                else
                {
                    Console.WriteLine($"Cleric heal {unit.GetType().Name}");
                    while (Mana >= 2 && (unit.Health < unit.MaxHealth))
                    {
                        unit.Health += 1;
                        Mana -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Cleric heal {unit}");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: Cleric Health: {Health} Manna: {Mana}");
        }
    }
}
