using StrategyUnits;


static void IncreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    Console.WriteLine($"{name} восстановил здоровье на {newHealth - oldHealth}. Текущее здоровье {newHealth}/{maxHealth}");
}

static void DecreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    Console.WriteLine($"{name} получил урон {oldHealth - newHealth}. Текущее здоровье {newHealth}/{maxHealth}");
}

Peasant peasant = new Peasant();
Footman footman = new Footman();
Healer healer = new Healer();
Palladin palladin = new Palladin();

peasant.HealthIncreasedEvent += IncreaseHealth;
peasant.HealthDecreasedEvent += DecreaseHealth;

peasant.ShowInfo();
footman.ShowInfo();
healer.ShowInfo();
palladin.ShowInfo();

footman.InflictDamage(peasant);
peasant.ShowInfo();
healer.HealSomeone(peasant);
healer.ShowInfo();
peasant.ShowInfo();

