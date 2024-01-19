using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int maxHP, string? name, int damage) : base(maxHP, name, damage) { }

        public void Rage(Unit unit)
        {
            if (CurrentHP < MaximumHP / 2)
            {
                Damage += Damage / 2;
                Console.WriteLine($"{Name} has less than half health: {CurrentHP}/{MaximumHP} ");
            }
            Console.WriteLine();
        }
    }
    
}
