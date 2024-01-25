using StrategyUnits;

Barracs barracs = new Barracs();
Altar altar = new Altar();
Forge forge = new Forge();

Peasant peasant = new Peasant();

Footman recruit = barracs.CreateRecruit();
Footman footman = barracs.CreateFootman();
Footman berserker = barracs.CreateBerserker();
Healer healer = altar.CreateHealer();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();


recruit.HealthIncreasedEvent += HealthIncrease;
recruit.HealthDecreasedEvent += HealthDecrease;

footman.HealthIncreasedEvent += HealthIncrease;
footman.HealthDecreasedEvent += HealthDecrease;

berserker.HealthIncreasedEvent += HealthIncrease;
berserker.HealthDecreasedEvent += HealthDecrease;

peasant.HealthIncreasedEvent += HealthIncrease;
peasant.HealthDecreasedEvent += HealthDecrease;

healer.HealthIncreasedEvent += HealthIncrease;
healer.HealthDecreasedEvent += HealthDecrease;

paladin.HealthIncreasedEvent += HealthIncrease;
paladin.HealthDecreasedEvent += HealthDecrease;

zealotKnight.HealthIncreasedEvent += HealthIncrease;
zealotKnight.HealthDecreasedEvent += HealthDecrease;

paladin.FireBall(healer);
paladin.ShowInfo();
paladin.ArmorHero();
paladin.ShowInfo();
paladin.ArmorHero();
paladin.ShowInfo();
paladin.ArmorHero();
paladin.ShowInfo();

Console.WriteLine();

paladin.FireBall(berserker);
paladin.FireBall(berserker);


Console.WriteLine();

zealotKnight.ShowInfo();
berserker.Attack(zealotKnight);
berserker.Attack(zealotKnight);
berserker.Attack(zealotKnight);

zealotKnight.Prayer();

Console.WriteLine();

recruit.ShowInfo();

paladin.FireBall(peasant);
healer.HealSomebody(peasant);

void HealthIncrease(string name, int health, int newHealth, int armor)
{
    Console.WriteLine($"Здоровье {name} увеличилось на {newHealth - health}. Текущее здоровье - {newHealth}. Броня - {armor}");
}
void HealthDecrease(string name, int health, int newHealth, int armor)
{
    Console.WriteLine($"Здоровье {name} уменьшилось на {health - newHealth}. Текущее здоровье - {newHealth}. Броня - {armor}");
}
Console.ReadKey();