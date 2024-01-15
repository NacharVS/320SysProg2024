using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(50, "Palladin", 5, 50)
        {
        }

        public void FireAttack(Unit unit)
        {
            Console.WriteLine($"{Name} атаковал огненным заклинанием {unit.Name}");
            unit.Health -= 10;
            Mana -= 2;
        }

        public override void InflictDamage(Unit unit)
        {
            Console.WriteLine($"{Name} ударил мечом {unit.Name}");
            base.InflictDamage(unit);
        }
    }
}
