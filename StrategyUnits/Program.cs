using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Cleric cleric = new Cleric();
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
cleric.HealSomebody(footman2);
Console.WriteLine(cleric.CurrentEnergy);
footman2.ShowInfo();
footman.InflictDamage(cleric);
cleric.ShowInfo();
cleric.HealSelf(cleric);
cleric.ShowInfo();
Console.WriteLine(cleric.CurrentEnergy);