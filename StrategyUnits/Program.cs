using StrategyUnits;

Footman footman = new Footman();
Peasant ps2 = new Peasant();
Peasant ps1 = new Peasant();
Cliric cl1 = new Cliric();
Cliric cl2 = new Cliric();

//Задание просмотр работы убийства
ps1.ShowInfo();
footman.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
Console.WriteLine();
//Задание с лечением и маной

ps2.ShowInfo();
footman.InflictDamage(ps2);
footman.InflictDamage(cl2);
ps2.ShowInfo();
cl2.ShowInfo();

cl1.InflictHeal(ps2);
cl1.InflictHeal(cl2);

ps2.ShowInfo();
cl2.ShowInfo();
Console.WriteLine("Клирик который лечил: ");
cl1.ShowInfo();
