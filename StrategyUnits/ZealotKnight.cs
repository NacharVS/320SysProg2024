using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {

        public ZealotKnight(int atackValue, string Name, int damage) : base(atackValue, Name, damage)
        {
            
        }
        public void Prayer()
        {
            if(Mana >= 10)
            {
                CurentHealth += 20;
                Mana -= 10;
            }
            else
            {
                Console.WriteLine("Недостаточно маны чтобы излечиться");
            }
        }
    }
}
