using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class ZeelotKnight : MilitaryUnit
    {
        public ZeelotKnight(int maxHP, string? name, int damage) : base(maxHP, name, damage) { }

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
