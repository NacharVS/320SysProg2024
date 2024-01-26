using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnits
    {
        public Healer(string? name, int health, int minDamage, int maxDamage, int shield, int maxMana) : base(name, health, minDamage, maxDamage, shield, maxMana)
        {

        }

        public void Heal(Unit unit)
        {
            while (Mana >= 2 && unit.MaxHealth - unit.Health > 0)
            {
                unit.Health += 1;
                Mana -= 2;
            }
        }

        
    }
}
