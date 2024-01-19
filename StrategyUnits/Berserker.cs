using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker: MilitaryUnit
    {

        public Berserker(int health, string? name, int damage) : base(health, name, damage) 
        {
            
        }

        public void Rage(Unit unit)
        {
            if (Health < (Health / 2))
            {
                Damage += Damage / 2;
                Console.WriteLine($"{Name} has less than half health: {Health}/{MaxHealth}, damage: {Damage}");
            }
            else
            {
                Console.WriteLine("");
            }
        }

    }
}
