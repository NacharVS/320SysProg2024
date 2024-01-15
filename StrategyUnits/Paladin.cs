using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base("Paladin", 60, 5, 60, 60)
        {

        }

        public override void MagicAttack(Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine($"Персонаж {unit.Name} мертв! Его нельзя атаковать!");
                return;
            }

            while (unit.DiedUnit == false || NowEnergy > 0)
            {
                NowEnergy -= 1;
                unit.Health -= 5;
            }
            Console.WriteLine($"Персонажу {unit.Name} нанесено максимальное количество урона с помощью магического удара. Он мертв.");
        }
    }
}
