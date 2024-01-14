using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Cliric cl1 = new Cliric();

ps1.ShowInfo();
footman.ShowInfo();

footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
cl1.InflictHeal(ps1);
ps1.ShowInfo();
