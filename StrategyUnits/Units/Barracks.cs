using StrategyUnits.Units;

namespace StrategyUnits
{
    internal class Barracks
    {
        public List<MilitaryUnit> warriors = new() { };
        public Footman CreateFootman(string nameOfUnit)
        {
            Footman footman =  new Footman(60, "Footman", 5, 20, 30, nameOfUnit);
            footman.HealthDecreasedEvent += HealthDecreased;
            footman.HealthIncreasedEvent += HealthIncreased;
            footman.UnitDiedEvent += UnitDied;
            warriors.Add(footman);
            return footman;
        }

        public Berserk CreateBerserk(string nameOfUnit)
        {
            Berserk berserk =  new Berserk(90, "Berserk", 7, 30, 40, nameOfUnit);
            berserk.HealthDecreasedEvent += HealthDecreased;
            berserk.HealthIncreasedEvent += HealthIncreased;
            berserk.UnitDiedEvent += UnitDied;
            berserk.RagedEvent += berserk.RageOn;
            berserk.UnragedEvent += berserk.RageOff;
            warriors.Add(berserk);
            return berserk;
        }

        public Healer CreateHealer(string nameOfUnit)
        {
            Healer healer = new Healer(40, "Healer", 2, 5, 20, 100, nameOfUnit);
            healer.HealthDecreasedEvent += HealthDecreased;
            healer.HealthIncreasedEvent += HealthIncreased;
            healer.UnitDiedEvent += UnitDied;
            warriors.Add(healer);
            return healer;
        }

        public ZealotKnight CreateZKnight(string nameOfUnit)
        {
            ZealotKnight zknight = new ZealotKnight(60, "Zealot Knight", 7, 10, 25, 80, nameOfUnit);
            zknight.HealthDecreasedEvent += HealthDecreased;
            zknight.HealthIncreasedEvent += HealthIncreased;
            zknight.UnitDiedEvent += UnitDied;
            warriors.Add(zknight);
            return zknight;
        }

        public Paladin CreatePaladin(string nameOfUnit)
        {
            Paladin paladin = new Paladin(110, "Paladin", 10, 40, 50, 60, nameOfUnit);
            paladin.HealthDecreasedEvent += HealthDecreased;
            paladin.HealthIncreasedEvent += HealthIncreased;
            paladin.UnitDiedEvent += UnitDied;
            paladin.HolyArmorOnEvent += paladin.HolyArmorOn;
            paladin.HolyArmorOffEvent += paladin.HolyArmorOff;
            warriors.Add(paladin);
            return paladin;
        }

        // Events

        static void HealthIncreased(int previousHealth, int currentHealth, int maxHealth)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"--------- INFO ---------\n" +
                $"Health was increased by {currentHealth - previousHealth} HP\n" +
                $"CURRENT HEALTH: {currentHealth}/{maxHealth}\n" +
                $"--------- ---- ---------\n");

        }
        static void HealthDecreased(int previousHealth, int currentHealth, int maxHealth)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"--------- INFO ---------\n" +
                $"Health was decreased by {previousHealth - currentHealth} HP\n" +
                $"CURRENT HEALTH: {currentHealth}/{maxHealth}\n" +
                $"--------- ---- ---------\n");
        }
        static void UnitDied()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Unit has died.\n");
        }
    }
}
