using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Cleric cleric = new Cleric();
Paladin paladin = new Paladin();
Altar altar = new Altar();
footman.HealthIncreasedEvent += IncreaseInLife;
footman.HealthDecreasedEvent += DecreaseInLife;
footman2.HealthIncreasedEvent += IncreaseInLife;
footman2.HealthDecreasedEvent += DecreaseInLife;
cleric.HealthIncreasedEvent += IncreaseInLife;
cleric.HealthDecreasedEvent += DecreaseInLife;
ps1.HealthIncreasedEvent += IncreaseInLife;
ps1.HealthDecreasedEvent += DecreaseInLife;
ps2.HealthIncreasedEvent += IncreaseInLife;
ps2.HealthDecreasedEvent += DecreaseInLife;

cleric.EnergyDecreasedEvent += DecreaseEnergy;
cleric.EnergyIncreasedEvent += IncreaseInEnergy;
paladin.EnergyDecreasedEvent += DecreaseEnergy;
paladin.EnergyIncreasedEvent += IncreaseInEnergy;


footman.Attack(ps2);


//cleric.ShowInfo();
//ps2.ShowInfo();
//ps2.Harvest();
//ps2.CleaningTheArea();
//ps2.EndOfWork();
//ps2.CleaningTheArea();

paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(ps2);
paladin.MagicAttack(cleric);
paladin.MagicAttack(cleric);

altar.RestoreEnergy(paladin);

static void DecreaseInLife(string? name, int health, int difference, int defence)
{
    Console.WriteLine($" Персонаж {name} был ранен. Жизни уменьшились на {difference}. Жизни = {health}");
}
static void IncreaseInLife(string? name, int health, int difference, int defence)
{
    Console.WriteLine($" Персонаж {name} был излечен. Жизни увеличились на {difference}. Жизни = {health}");
}

static void DecreaseEnergy(string name, int energy, int difference)
{
    Console.WriteLine($" Энергия персонажа {name} уменьшена на {difference}, энергия сейчас = {energy}");
}

static void IncreaseInEnergy(string name, int energy, int difference)
{
    Console.WriteLine($" Энергия персонажа {name} увеличена на {difference}, энергия сейчас = {energy}");
}