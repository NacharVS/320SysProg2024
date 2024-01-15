using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric1 = new Cleric();
ps1.HealthChangedEvent += Method;

ps1.ShowInfo();
footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);


cleric1.Heal(ps1);
ps1.ShowInfo();



static void Method(int number)
{
    Console.WriteLine($"Health has changed. CurrentHealth{number}");
}

