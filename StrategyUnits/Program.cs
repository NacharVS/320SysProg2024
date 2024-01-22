using StrategyUnits;


Altar altar = new Altar();
Barrack barrack = new Barrack();
Forge forge = new Forge();

Peasant ps1 = new Peasant();

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


footman.Attack(paladin);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
berserker.ShowInfo();
paladin.HolyFire(berserker);
berserker.ShowInfo();

forge.ArmorUpgrade(paladin);


zealotKnight.ShowInfo();

paladin.HolyFire(zealotKnight);
paladin.HolyFire(zealotKnight);
paladin.HolyFire(zealotKnight);
zealotKnight.Player();
static void DecreaseInLife(string? name, double health, double difference)
{
    Console.WriteLine($" Персонаж {name} был ранен. Жизни уменьшились на {difference}. Жизни = {health}");
}
static void IncreaseInLife(string? name, double health, double difference)
{
    Console.WriteLine($" Персонаж {name} был излечен. Жизни увеличились на {difference}. Жизни = {health}");
}

static void DecreaseEnergy(string name, double energy, double difference)
{
    Console.WriteLine($" Энергия персонажа {name} уменьшена на {difference}, энергия сейчас = {energy}");
}

static void IncreaseInEnergy(string name, double energy, double difference)
{
    Console.WriteLine($" Энергия персонажа {name} увеличена на {difference}, энергия сейчас = {energy}");
}