using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer = new Healer(50);

healer.ShowInfo();
footman.ShowInfo();
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);
footman.InflictDamage(healer);

footman.InflictDamage(healer);
healer.Healself();
healer.ShowInfo();