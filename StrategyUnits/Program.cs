using StrategyUnits;
using System.Net.Mail;

static void IncreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    if(newHealth > maxHealth)
        newHealth = maxHealth;
    Console.WriteLine($"{name} восстановил здоровье на {newHealth - oldHealth}. Текущее здоровье {newHealth}/{maxHealth}");
}

static void DecreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    int damage = oldHealth - newHealth;
    if (newHealth < 0)
        newHealth = 0;
    Console.WriteLine($"{name} получил урон {damage}. Текущее здоровье {newHealth}/{maxHealth}");
}

Peasant peasant = new Peasant();
Footman footman = new Footman();
Healer healer = new Healer();
Palladin palladin = new Palladin();
Altar altar = new Altar();

peasant.HealthIncreasedEvent += IncreaseHealth;
peasant.HealthDecreasedEvent += DecreaseHealth;
footman.HealthIncreasedEvent += IncreaseHealth;
footman.HealthDecreasedEvent += DecreaseHealth;
healer.HealthIncreasedEvent += IncreaseHealth;
healer.HealthDecreasedEvent += DecreaseHealth;
palladin.HealthIncreasedEvent += IncreaseHealth;
palladin.HealthDecreasedEvent += DecreaseHealth;

peasant.ShowInfo();
footman.ShowInfo();
healer.ShowInfo();
palladin.ShowInfo();

