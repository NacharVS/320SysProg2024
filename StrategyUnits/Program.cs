using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();

ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
Healer healer = new Healer();
healer.ToHeal(ps1);
ps1.ShowInfo();