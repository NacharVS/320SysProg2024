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

        public void Prayer(ZeelotKnight zeelotKnight)
        {

            if (DeadPerson == true)
            {
                Console.WriteLine($"{zeelotKnight.Name} died and can't pray.");
                return;
            }
            else if(zeelotKnight.Manna >= 10)
            {
                zeelotKnight.Health += 20;
                Manna -= 10;
                Console.WriteLine($"{zeelotKnight.Name} operation was successfully.");
            }
            else
            {
                Console.WriteLine("Not enough manna for pray.");
            }
        }   

    }

}
