using StrategyUnits;
using StrategyUnits.Units;

var barrack = new Barrack("Казарма");
var altar = new Altar(100, 100, "Алтарь");
var forge = new Forge("Кузница");

var footman = barrack.CreateFootman();
var recruit = barrack.CreateRecruit();
var berserker = barrack.CreateBerserker();

var peasant = new Peasant("Крестьянин", false, 5, 5, false);

var paladin = altar.CreatePaladin();
var cleric = altar.CreateCleric();


cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
cleric.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
cleric.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

peasant.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
peasant.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

altar.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
altar.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;

berserker.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
berserker.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

recruit.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
recruit.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

peasant.PlowField();
peasant.ShowInformation();

footman.Attack(peasant);

peasant.FinishWork();
peasant.ShowInformation();

footman.Attack(berserker);
footman.Attack(berserker);
forge.UpdateWeapons();
berserker.ShowInformation();
cleric.HealSomebody(berserker);
altar.RecoveryEnergy(cleric);
altar.RestoreEnergy();

altar.ShowInformation();
cleric.ShowInformation();
paladin.ShowInformation();

static void ShowInformationAfterLossOfHealth(string? name, double health, double difference, double maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{name} получил урон, здоровье уменьшилось на {difference}, текущее здоровье: {health}/{maxHealth}");
    Console.ForegroundColor = ConsoleColor.White;
}

static void ShowInformationAfterHealthIsRestored(string? name, double health, double difference, double maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{name} был излечён, здоровье увеличилось на {difference}, текущее здоровье: {health}/{maxHealth}");
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
