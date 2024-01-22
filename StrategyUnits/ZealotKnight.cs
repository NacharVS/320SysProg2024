using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        private int _defense;
        public ZealotKnight(string? name, int maxHP, int protection, int damage, int maxMana) : base(name, maxHP, protection, damage, maxMana) { }
        public void Prayer()
        {
            if (DeadUnit == false)
            {
                if (Mana >= 10)
                {
                    CurrentHP += 20;
                    Mana -= 10;
                    Console.WriteLine($"{Name} помолился.");
                }
                else
                {
                    Console.WriteLine($"{Name} не хватает маны.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} мертв.");
            }
        }
    }
}
