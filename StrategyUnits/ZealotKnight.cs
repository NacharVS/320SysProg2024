using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(int health, string name, int damage, int maxMana, int armor) : base(health, name, damage, maxMana, armor)
        {
        }

        public void Prayer()
        {
            if (Health == MaxHealth)
            {
                Console.WriteLine($"У {Name} полное здоровье");
            }
            else if (Mana >= 10)
            {
                Health += 20;
                Mana -= 10;
                Console.WriteLine($"{Name} Помолился");
            }
            else
            {

                Console.WriteLine($" У {Name} не хватает маня для молитвы {10 - Mana}");
            }

        }

    }
}
