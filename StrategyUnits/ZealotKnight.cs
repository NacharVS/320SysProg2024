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
        public void Prayer(ZealotKnight zealotKnight)
        {
            if (DeadUnit == false)
            {
                if (zealotKnight.Mana >= 10)
                {
                    CurrentHP += 20;
                    Mana -= 10;
                    Console.WriteLine("Zealot Knight prayed.");
                }
                else
                {
                    Console.WriteLine("Zealot Knight doesn't have mana.");
                }
            }
            else
            {
                Console.WriteLine("Zealot Knight is dead.");
            }
        }
    }
}
