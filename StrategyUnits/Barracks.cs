using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateFootman(string nameOfUnit)
        {
            Footman footman =  new Footman(60, "Footman", 2, 50, 60, nameOfUnit);
            footman.HealthDecreasedEvent += HealthDecreased;
            footman.HealthIncreasedEvent += HealthIncreased;
            footman.UnitDiedEvent += UnitDied;
            return footman;
        }

        public Berserk CreateBerserk(string nameOfUnit)
        {
            Berserk berserk =  new Berserk(90, "Berserk", 4, 3, 10, nameOfUnit);
            berserk.HealthDecreasedEvent += HealthDecreased;
            berserk.HealthIncreasedEvent += HealthIncreased;
            berserk.UnitDiedEvent += UnitDied;
            berserk.RagedEvent += berserk.RageOn;
            berserk.UnragedEvent += berserk.RageOff;
            return berserk;
        }

        static void HealthIncreased(int previousHealth, int currentHealth, int maxHealth)
        {
            
            Console.WriteLine($"--------- INFO ---------\n" +
                $"Health was increased by {currentHealth - previousHealth} HP\n" +
                $"CURRENT HEALTH: {currentHealth}/{maxHealth}\n" +
                $"--------- ---- ---------\n");

        }
        static void HealthDecreased(int previousHealth, int currentHealth, int maxHealth)
        {
            Console.WriteLine($"--------- INFO ---------\n" +
                $"Health was decreased by {previousHealth - currentHealth} HP\n" +
                $"CURRENT HEALTH: {currentHealth}/{maxHealth}\n" +
                $"--------- ---- ---------\n");
        }
        static void UnitDied()
        {
            Console.WriteLine("Unit has died.\n");
        }
    }
}
