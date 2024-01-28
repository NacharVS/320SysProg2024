using StrategyUnits;
using StrategyUnits.Units;

var barrack = new Barrack();
var altar = new Altar();
var forge = new Forge();

var footman = barrack.CreateFootman();
var recruit = barrack.CreateRecruit();

var paladin = altar.CreatePaladin();
var cleric = altar.CreateCleric();


cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;

paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

recruit.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
recruit.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

footman.Attack(paladin);
forge.UpdateWeapons();
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
cleric.HealSomebody(paladin);


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
