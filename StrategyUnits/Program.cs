using StrategyUnits;

Healer healer = new("Almir");
Footman footman = new("Insaf");
healer.HealthIncreasedEvent += HealthIncreased;
healer.HealthDecreasedEvent += HealthDecreased;
healer.ShowInfo();

footman.Attack(healer);
healer.Healself();


static void HealthIncreased(int previousHealth, int currentHealth, int maxHealth)
{
    Console.WriteLine($"--------- INFO ---------\n Health was increased by {currentHealth-previousHealth} HP\nCURRENT HEALTH: {currentHealth}/{maxHealth}\n--------- ---- ---------\n");

}
static void HealthDecreased(int previousHealth, int currentHealth, int maxHealth)
{
    Console.WriteLine($"--------- INFO ---------\n Health was decreased by {previousHealth - currentHealth} HP\nCURRENT HEALTH: {currentHealth}/{maxHealth}\n--------- ---- ---------\n");
}