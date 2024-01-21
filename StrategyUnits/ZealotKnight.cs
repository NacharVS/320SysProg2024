using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(string? name, int health, int minDamage, int maxDamage, int shield, int maxMana) : base(name, health, minDamage, maxDamage, shield, maxMana)
        {

        }

        public void Prayer()
        {
            if (Mana >= 10)
            {
                Console.WriteLine($"{Name} помолился");
                Health += 20;
                Mana -= 10;
            }
            else
            {
                Console.WriteLine("Недостаточно маны для молитвы");
            }
            
        }
    }
}
