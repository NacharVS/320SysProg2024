using StrategyUnits;

Healer healer = new("Almir");
Footman footman = new("Insaf");
Paladin paladin = new("Kirill");
Altar altar = new("The Great Altar");
healer.HealthIncreasedEvent += HealthIncreased;
healer.HealthDecreasedEvent += HealthDecreased;
healer.UnitDiedEvent += UnitDied;
footman.HealthIncreasedEvent += HealthIncreased;
footman.HealthDecreasedEvent += HealthDecreased;
footman.UnitDiedEvent += UnitDied;
paladin.HealthIncreasedEvent += HealthIncreased;
paladin.HealthDecreasedEvent += HealthDecreased;
paladin.UnitDiedEvent += UnitDied;
healer.ShowInfo();
footman.ShowInfo();
paladin.ShowInfo();

paladin.AttackMagically(footman);
paladin.AttackMagically(footman);

healer.HealSomebody(footman);

footman.ShowInfo();
healer.ShowInfo();
paladin.ShowInfo();

altar.RestoreMana(healer);
altar.RestoreMana(paladin);


static void HealthIncreased(int previousHealth, int currentHealth, int maxHealth)
{
    Console.WriteLine($"--------- INFO ---------\n" +
        $"Health was increased by {currentHealth-previousHealth} HP\n" +
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