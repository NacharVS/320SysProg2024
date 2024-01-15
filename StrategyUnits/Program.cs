using StrategyUnits;

Footman footman = new Footman();
Peasant peasant = new Peasant();
Healer healer = new Healer();
Paladin paladin = new Paladin();
Altar altar = new Altar();

peasant.HealthIncreasedEvent += HealthIncrease;
peasant.HealthDecreasedEvent += HealthDecrease;

paladin.FireBall(peasant);


void HealthIncrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} равно {newHealth}");
}
void HealthDecrease(string name, int health, int newHealth)
{
    Console.WriteLine($"Здоровье {name} равно {newHealth}");
}