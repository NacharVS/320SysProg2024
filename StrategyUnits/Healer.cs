using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base(40, "Healer", 3, 60)
        {
        }

        public void HealSomeone(Unit unit)
        {
            Console.WriteLine($"{Name} начал лечить {unit.Name}");
            while (unit.MaxHealth - unit.Health > 0 && Mana > 1)
            {
                unit.Health += 1;
                Mana -= 2;
            }
        }

        public void HealSelf()
        {
            Console.WriteLine($"{Name} начал лечить сам себя");
            while (MaxHealth - Health > 0 && Mana > 0)
            {
                Health += 2;
                Mana -= 1;
            }
        }

        public override void InflictDamage(Unit unit)
        {
            Console.WriteLine($"{Name} ударил топором {unit.Name}");
            base.InflictDamage(unit);
        }
    }
}
