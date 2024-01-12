using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric = new Cleric();
Cleric cleric2 = new Cleric();

//ps1.ShowInfo();
//footman2.ShowInfo();
//footman.InflictDamage(ps1);
//footman.InflictDamage(footman2);
Console.WriteLine("Первоначальные данные");
ps1.ShowInfo();
footman2.ShowInfo();
cleric.ShowInfo();
cleric.GetInfoCleric();

Console.WriteLine("\nХилл пс1 Пеасант");
cleric.HillOthers(ps1);
ps1.ShowInfo();

Console.WriteLine("\nПосле хилла:");
cleric.ShowInfo();
cleric.GetInfoCleric();


Console.WriteLine("\nПосле хилла самого себя:");
cleric.HillMyself(cleric);
cleric.ShowInfo();
cleric.GetInfoCleric();

footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);
footman.InflictDamage(cleric2);

Console.WriteLine("Первый клерик лечит второго");
Console.WriteLine("Первый клерик");
cleric.ShowInfo();
cleric.GetInfoCleric();

Console.WriteLine("Second клерик");
cleric2.ShowInfo();
cleric2.GetInfoCleric();
cleric.HillOthers(cleric2);

Console.WriteLine("\nПосле хилла:");
Console.WriteLine("Первый клерик");
cleric.ShowInfo();
cleric.GetInfoCleric();
Console.WriteLine("Second клерик");
cleric2.ShowInfo();
cleric2.GetInfoCleric();


