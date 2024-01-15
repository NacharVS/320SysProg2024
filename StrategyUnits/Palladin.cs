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
            unit.Health -= 10;
            Mana -= 2;
            Console.WriteLine("Палладин атаковал огненным заклинанием");
        }

        public override void InflictDamage(Unit unit)
        {
            base.InflictDamage(unit);
            Console.WriteLine("Палладин ударил мечом");
        }
    }
}
