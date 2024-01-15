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
            while (unit.MaxHealth - unit.Health > 0 && Mana > 1)
            {
                unit.Health += 1;
                Mana -= 2;
            }
        }

        public void HealSelf()
        {        
            while (MaxHealth - Health > 0 && Mana > 0)
            {
                Health += 2;
                Mana -= 1;
            }
        }

        public override void InflictDamage(Unit unit)
        {
            base.InflictDamage(unit);
            Console.WriteLine("Лекарь ударил топором");
        }
    }
}
