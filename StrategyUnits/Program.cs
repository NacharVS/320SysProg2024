using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric1 = new Cleric();
Altar altar1 = new Altar();

ps1.HealthDecreasedEvent += MethodOfDamage;
ps1.HealthIncreasedEvent += MethodOfHeal;
ps1.ShowInfo();
footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);


cleric1.ShowInfo();
cleric1.Heal(ps1);
ps1.ShowInfo();
cleric1.ShowInfo();
altar1.ShowInfo();
altar1.HealAltar(cleric1);

cleric1.ShowInfo();

altar1.ShowInfo();



static void MethodOfDamage(Unit target, int beforeHP)
{
    if (beforeHP < 0)
    {
        beforeHP = 0;
    }
    Console.WriteLine($"Health has decreased to {target.Name} on {target.Health - beforeHP} CurrentHealth {beforeHP}");
}

static void MethodOfHeal(Unit target, int healHP)
{
    if (healHP > target.MaxHealth)
    {
        healHP = target.MaxHealth;
    }
    Console.WriteLine($"Health has increased to {target.Name} on {healHP - target.Health} CurrentHealth {healHP}");
}

