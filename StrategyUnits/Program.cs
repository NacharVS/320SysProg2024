using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Cleric cleric = new Cleric();

ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps2);
ps2.ShowInfo();
cleric.HealOther(ps2);
ps2.ShowInfo();