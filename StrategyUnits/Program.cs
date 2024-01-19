using StrategyUnits;
Barrack barrack = new Barrack();
Altar altar = new Altar();
Footman recruit = barrack.CreateRecruit();
Footman footman = barrack.CreateFootman();
Cleric cleric = new Cleric();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();
zealotKnight.ShowInfo();
paladin.ShowInfo();
footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

cleric.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
cleric.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

footman.Attack(footman);
cleric.HealSomebody(footman);
footman.Attack(cleric);
cleric.HealSelf(cleric);
altar.RestoreEP(cleric);
cleric.HealSelf(cleric);
paladin.HolyFire(footman);


static void ShowInformationAfterLossOfHealth(string? name, int health, int difference, int protection, int maxHealth)
{
    Console.WriteLine($"\u001b[31m{name} получил урон, здоровье уменьшилось на {difference}\u001b[0m \u001b[36m(поглащено урона: {protection}\u001b[0m),\u001b[31m текущее здоровье: {health}/{maxHealth}\u001b[0m");
}
static void ShowInformationAfterHealthIsRestored(string? name, int health, int difference, int protection, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{name} был излечн, здоровье увеличилось на {difference}, текущее здоровье: {health}/{maxHealth}, защита: {protection}");
    Console.ForegroundColor = ConsoleColor.White;

}

void ShowInformationAfterLossOfEnergy(string name, int energy, int difference, int maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия уменьшена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowInformationAfterEnergyIsRestored(string name, int energy, int difference, int maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия увеличена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}
