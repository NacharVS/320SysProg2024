using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Battle
    {
        public void Battles(MilitaryUnit unit, MilitaryUnit unit2)
        {
            if (unit.Health < unit2.Health)
            {
                Console.WriteLine($"Первым атакует (1) {unit.Name}");
                while (unit.Health > 0 && unit2.Health > 0)
                {
                    unit.Attack(unit2);
                    if (unit2.Health == 0)
                        break;
                    else
                        unit2.Attack(unit);
                }
                if (unit.Health == 0)
                    Console.WriteLine($"победил {unit2.Name}");
                else if (unit2.Health == 0)
                    Console.WriteLine($"победил {unit.Name}");
                else if (unit.Health == 0 && unit2.Health == 0)
                    Console.WriteLine($"Победителя нет");
            }
            else
            {
                Console.WriteLine($"Первым атакует (2) {unit2.Name}");
                while (unit.Health > 0 && unit2.Health > 0)
                {
                    unit2.Attack(unit);
                    if (unit.Health == 0)
                        break;
                    else
                        unit.Attack(unit2);
                }
                if (unit.Health == 0)
                    Console.WriteLine($"победил {unit2.Name}");
                else if (unit2.Health == 0)
                    Console.WriteLine($"победил {unit.Name}");
                else if (unit.Health == 0 && unit2.Health == 0)
                    Console.WriteLine($"Победителя нет");
            }
        }
    }
}
