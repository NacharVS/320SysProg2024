using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Cleric cleric1 = new Cleric();

//проверка на взаимодейсвие мертвого unit с другими unit
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//cleric1.Heal(ps1);
//ps1.ShowInfo();
//cleric1.Heal(ps1);
//ps1.ShowInfo();

//Console.WriteLine();
//Console.WriteLine();

//проверка на heal
ps2.ShowInfo();
cleric1.ShowInfo();
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);
ps2.ShowInfo();
cleric1.Heal(ps2);
cleric1.ShowInfo();
cleric1.Heal(ps2);



