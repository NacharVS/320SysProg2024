using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base("Paladin", 50, 3, 5, 10, 50)
        {

        }

        public void FireBall(Unit unit)
        {
            unit.Health -= 12;
            Mana -= 3;
            Console.WriteLine("Атаковал огненным шаром");
        }
    }
}