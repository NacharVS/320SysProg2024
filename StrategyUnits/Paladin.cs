using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
<<<<<<< Updated upstream
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(2, 15, "Paladin", 50)
        {
        }
    }
}
=======
    internal class Paladin : ZeelotKnights
    {
        public Paladin(int minDamage, int maxDamage, string? name, int Health, int protection) : base(minDamage, maxDamage, name, Health, protection)
        {
        }

        public void FireBall(Unit unit)
        {
            if (unit.isAlive)
            {
                unit.Health -= 50;
                Manna -= 10;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
        public void HolyArmor()
        {
            if(Protection == 8)
            {
                Console.WriteLine("The \"Holy armor\" has already been used");
                return;
            }
            else if(!isAlive)
            {
                Console.WriteLine($"{Name} is dead");
                return;
            }
            if(Manna < 10)
            {
                Console.WriteLine($"MP is not enough");
                return;
            }
            Console.WriteLine("\"Holy armor\" activated");
            Manna -= 10;
            Protection = 8;
        }
    }
}
>>>>>>> Stashed changes
