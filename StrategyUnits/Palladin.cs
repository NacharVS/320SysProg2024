using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin: MagicUnit
    {
        public Palladin() : base(90, "Palladin", 9, 20)
        {
            
        }
        public void HollyFireAttack(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine("Palladin died.");
            }
            else if (Manna < 4)
            {
                Console.WriteLine("Not enough manna.");
            }
            else
            {
                if (unit.Health == 0)
                { Console.WriteLine($"Unit can't magic attack. {unit.Name} died."); }
                else
                {
                    unit.Health -= 9;
                    Manna -= 4;
                    Console.WriteLine($"Palladin take magic attack: {unit.Name}");
                }
            }
        }

        public void HollyArmorAttack(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine("Palladin died.");
            }
        }
    }
}
