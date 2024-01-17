using StrategyUnits;
Footman footman = new Footman();
Footman footman2 = new Footman();
Cleric cleric = new Cleric();
Altar altar = new Altar();
Paladin paladin = new Paladin();

footman2.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman2.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

cleric.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
cleric.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

footman.Attack(footman2);
cleric.HealSomebody(footman2);
footman.Attack(cleric);
cleric.HealSelf(cleric);
altar.RestoreEP(cleric);
cleric.HealSelf(cleric);
paladin.MagicAttack(footman2);


static void ShowInformationAfterLossOfHealth(string? name, int health, int difference)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{name} was stick, health reduced by {difference}, current health: {health}");
    Console.ForegroundColor = ConsoleColor.White;

}
static void ShowInformationAfterHealthIsRestored(string? name, int health, int difference)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{name} has been cured, health increased by {difference}, current health: {health}");
    Console.ForegroundColor = ConsoleColor.White;

}

void ShowInformationAfterLossOfEnergy(string name, int energy, int difference)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} energy reduced by {difference}, current energy: {energy}");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowInformationAfterEnergyIsRestored(string name, int energy, int difference)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} energy increased by {difference}, current energy: {energy}");
    Console.ForegroundColor = ConsoleColor.White;
}
