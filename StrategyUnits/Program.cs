using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric1 = new Cleric();

ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();

cleric1.Heal(ps1);
ps1.ShowInfo();
