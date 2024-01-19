using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZeelotKnights : MagicUnit
    {
        public ZeelotKnights(int minDamage, int maxDamage, string? name, int Health, int protection) : base(minDamage, maxDamage, name, Health, protection)
        {
        }
        public void Pray()
        {
            if (Health == MaxHealth)
            {
                Console.WriteLine($"{Name}'s health is full");
                return;
            }
            else if (!isAlive)
            {
                Console.WriteLine($"{Name} is dead");
                return;
            }
            if (Manna < 10)
            {
                Console.WriteLine($"MP is not enough");
                return;
            }
            Console.WriteLine("\"Pray\" use. HP was added");
            Manna -= 10;
            Health += 20;
        }
    }
}
