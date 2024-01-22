using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZeelotKnight : MagicUnit
    {

        public int Shield { get; private set; }
        public ZeelotKnight(int health, string? name, int damage, int manna, int guard) : base(health, name, damage, manna, guard)
        {
            
        }

        public void Prayer()
        {

            if (DeadPerson)
            {
                Console.WriteLine($"{Name} died and can't pray.");
                return;
            }
            else if(Manna >= 10)
            {
                Health += 20;
                Manna -= 10;
                Console.WriteLine($"{Name} operation was successfully.");
            }
            else
            {
                Console.WriteLine("Not enough manna for pray.");
            }
        }   

    }

}
