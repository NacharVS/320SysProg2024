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

paladin.HolyFire(healer);
paladin.ShowInfo();
paladin.HolyArmor();
paladin.ShowInfo();
paladin.HolyArmor();
paladin.ShowInfo();

zealotKnight.Prayer();

paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);
paladin.HolyFire(berserker);

berserker.InflictDamage(recruit);

void HealthIncrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} увеличилось на {newHealth - health}. Текущее здоровье - {newHealth}");
}
void HealthDecrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} уменьшилось на {health - newHealth}. Текущее здоровье - {newHealth}");
}