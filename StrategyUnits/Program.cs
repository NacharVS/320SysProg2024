using StrategyUnits;


Altar altar = new Altar(100);
Barrack barrack = new Barrack();
Forge forge = new Forge();

Peasant ps1 = new Peasant("Крестьянин", false, 30);

Cleric cleric = altar.CreateCleric();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();

Footman footman = barrack.CreateFootman();
Berserker berserker = barrack.CreateBerserker();

ps1.HealthIncreasedEvent += IncreaseInLife;
ps1.HealthDecreasedEvent += DecreaseInLife;

paladin.EnergyDecreasedEvent += DecreaseEnergy;
paladin.EnergyIncreasedEvent += IncreaseInEnergy;
paladin.HealthIncreasedEvent += IncreaseInLife;
paladin.HealthDecreasedEvent += DecreaseInLife;

cleric.HealthIncreasedEvent += IncreaseInLife;
cleric.HealthDecreasedEvent += DecreaseInLife;
cleric.EnergyDecreasedEvent += DecreaseEnergy;
cleric.EnergyIncreasedEvent += IncreaseInEnergy;

zealotKnight.HealthIncreasedEvent += IncreaseInLife;
zealotKnight.HealthDecreasedEvent += DecreaseInLife;
zealotKnight.EnergyDecreasedEvent += DecreaseEnergy;
zealotKnight.EnergyIncreasedEvent += IncreaseInEnergy;

footman.HealthIncreasedEvent += IncreaseInLife;
footman.HealthDecreasedEvent += DecreaseInLife;

berserker.HealthIncreasedEvent += IncreaseInLife;
berserker.HealthDecreasedEvent += DecreaseInLife;


footman.Attack(cleric);
cleric.HealSomebody(cleric);
altar.RecoveryEnergy(cleric);
static void DecreaseInLife(string? name, double health)
{
    Console.WriteLine($" Персонаж {name} был ранен. Жизни = {health}");
}
static void IncreaseInLife(string? name, double health)
{
    Console.WriteLine($" Персонаж {name} был излечен. Жизни = {health}");
}

static void DecreaseEnergy(string name, double energy)
{
    Console.WriteLine($" Энергия персонажа {name} уменьшена, энергия сейчас = {energy}");
}

static void IncreaseInEnergy(string name, double energy)
{
    Console.WriteLine($" Энергия персонажа {name} увеличена, энергия сейчас = {energy}");
}