using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Cleric cl1 = new Cleric();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
cl1.ShowInfo();
cl1.SelfHeal(cl1);
cl1.ShowInfo();
cl1.OtherHeal(ps1);
ps1.ShowInfo();
cl1.ShowInfo();
cl1.ShowInfoCleric();

footman2.ShowInfo();
footman.InflictDamage(cl1);
cl1.ShowInfo();
cl1.SelfHeal(ps1);
cl1.ShowInfo();
cl1.ShowInfoCleric();


footman2.ShowInfo();
footman.InflictDamage(cl1);
cl1.ShowInfo();
cl1.SelfHeal(ps1);
cl1.ShowInfo();
cl1.ShowInfoCleric();