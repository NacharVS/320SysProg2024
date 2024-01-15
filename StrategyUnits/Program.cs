using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Cleric cleric = new Cleric();
ps2.HealthChangedEvent += Method;

ps2.ShowInfo();
//footman.Attack(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
footman.Attack(ps2);


cleric.HealOther(ps2);
cleric.ShowInfo();
ps2.ShowInfo();

ps2.Harvest();
ps2.CleaningTheArea();
ps2.EndOfWork();
ps2.CleaningTheArea();

static void Method(int number)
{
    Console.WriteLine($"Жизни изменены. Текущие жизни {number}");
}