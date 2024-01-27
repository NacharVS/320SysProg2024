using StrategyUnits;
using StrategyUnits.Units;

var barrack = new Barrack();
var footman = barrack.CreateFootman();
var recruit = barrack.CreateRecruit();

footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

recruit.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
recruit.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

footman.Attack(recruit);


static void ShowInformationAfterLossOfHealth(string? name, double health, double difference, double maxHealth)
{
    Console.WriteLine($"\u001b[31m{name} получил урон, здоровье уменьшилось на {difference}\u001b[0m, текущее здоровье: {health}/{maxHealth}\u001b[0m");
}

static void ShowInformationAfterHealthIsRestored(string? name, double health, double difference, double maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{name} был излечён, здоровье увеличилось на {difference}, текущее здоровье: {health}/{maxHealth}");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowInformationAfterLossOfEnergy(string name, double energy, double difference, double maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия уменьшена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowInformationAfterEnergyIsRestored(string name, double energy, double difference, double maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия увеличена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}
