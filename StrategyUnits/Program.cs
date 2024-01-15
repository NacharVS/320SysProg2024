using StrategyUnits;

Console.WriteLine("...");
Console.WriteLine("\"Create some persons\"");
Footman footman = new Footman(13, 60);
Footman footman2 = new Footman(15, 50);
Peasant ps1 = new Peasant();
Healer healer = new Healer(50);
footman.ShowInfo();
footman2.ShowInfo();
Console.WriteLine("...");
Console.WriteLine("\"Try to murder footman...\"");
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();
footman.InflictDamage(footman2);
footman2.ShowInfo();

Console.WriteLine("...");
Console.WriteLine("\"Doing something))\"");
ps1.Move();
ps1.Build();

Console.WriteLine("...");
Console.WriteLine("\"True crime\"");
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();

Console.WriteLine("...");
Console.WriteLine("\"Healing, ura\"");
footman.InflictDamage(healer);
healer.ShowInfo();
healer.ToHeal(ps1);
ps1.ShowInfo();

Console.WriteLine("...");
Console.WriteLine("\"SelfHealing, ura\"");
healer.ToHeal(healer);

Console.WriteLine("...");
Console.WriteLine("\"Another true crime\"");
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();

Console.WriteLine("...");
Console.WriteLine("\"Peasant can collect something\"");
ps1.Collecting();
ps1.Collecting();
ps1.Collecting();