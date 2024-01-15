using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base("Palladin", 50, 5, "мечом", 40)
        {
        }

        public void FireAttack(Unit unit)
        {
            Console.WriteLine($"{Name} атаковал огненным заклинанием {unit.Name}");
            unit.Health -= 10;
            Mana -= 5;
        }
    }
}
