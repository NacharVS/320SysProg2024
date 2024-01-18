using StrategyUnits;

Footman footman = new Footman();
Peasant peasant = new Peasant();
Healer healer = new Healer();
Paladin paladin = new Paladin();
Altar altar = new Altar();

footman.HealthIncreasedEvent += HealthIncrease;
footman.HealthDecreasedEvent += HealthDecrease;

peasant.HealthIncreasedEvent += HealthIncrease;
peasant.HealthDecreasedEvent += HealthDecrease;

healer.HealthIncreasedEvent += HealthIncrease;
healer.HealthDecreasedEvent += HealthDecrease;

paladin.HealthIncreasedEvent += HealthIncrease;
paladin.HealthDecreasedEvent += HealthDecrease;

paladin.FireBall(peasant);
healer.HealSomebody(peasant);

void HealthIncrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} увеличилось на {newHealth - health}. Текущее здоровье - {newHealth}");
}
void HealthDecrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} уменьшилось на {health - newHealth}. Текущее здоровье - {newHealth}");
}