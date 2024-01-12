using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer = new Healer(60);

ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.Collect_food();
ps1.Collect_wood();
ps1.ShowInfo();

healer.Heal(ps1);
ps1.ShowInfo();

healer.ShowInfo();
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
healer.ShowInfo();
healer.Healself();
healer.ShowInfo();




