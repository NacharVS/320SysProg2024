using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric1 = new Cleric();
ps1.HealthDecreasedEvent += Method;

ps1.ShowInfo();
footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);


cleric1.Heal(ps1);
ps1.ShowInfo();



static void Method(Unit target, int beforeHP)
{
    Console.WriteLine($"Health has decreased to {target.Name} on {beforeHP-target.Health} CurrentHealth {target.Health}");
}

