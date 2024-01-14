using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Cliric cl1 = new Cliric();
Cliric cl2 = new Cliric();

ps1.ShowInfo();
//footman.ShowInfo();

//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(cl2);
ps1.ShowInfo();
cl2.ShowInfo();
cl1.InflictHeal(ps1);
cl1.InflictHeal(cl2);
ps1.ShowInfo();
cl2.ShowInfo();
cl1.ShowInfo();
