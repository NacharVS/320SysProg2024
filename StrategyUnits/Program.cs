using StrategyUnits;

Footman footman1 = new Footman();
Peasant ps1 = new Peasant();

// basic footman1 test

footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// health cannot be above 0 test

footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// cannot deal damage to dead units

footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// peasant cannot heal himself dead

ps1.ShowInfo();

ps1.HealSelf();

ps1.ShowInfo();

Console.WriteLine();

// basic peasant self-heal test

Footman footman2 = new Footman();
Peasant ps2 = new Peasant();

footman2.ShowInfo();
ps2.ShowInfo();

footman2.InflictDamage(ps2);
ps2.ShowInfo();

ps2.HealSelf();
ps2.ShowInfo();

Console.WriteLine();

// peasant cannot heal self to more than max health test

ps2.ShowInfo();

ps2.HealSelf();
ps2.ShowInfo();
ps2.HealSelf();
ps2.ShowInfo();
ps2.HealSelf();
ps2.ShowInfo();
ps2.HealSelf();
ps2.ShowInfo();

Console.WriteLine();

// basic peasant heal somebody test

Peasant ps3 = new Peasant();

ps3.ShowInfo();

footman2.InflictDamage(ps3);
ps3.ShowInfo();

ps2.HealSomebody(ps3);
ps3.ShowInfo();

Console.WriteLine();

// peasant cannot heal somebody to more than max health test

Peasant ps4 = new Peasant();
Peasant ps5 = new Peasant();

ps4.ShowInfo();
ps3.ShowInfo();

ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps4.HealSomebody(ps3);
ps3.ShowInfo();
ps5.HealSomebody(ps3);
ps3.ShowInfo();
ps5.HealSomebody(ps3);
ps3.ShowInfo();
ps5.HealSomebody(ps3);
ps3.ShowInfo();

Console.WriteLine();

// peasant cannot heal somebody dead

ps5.ShowInfo();
ps1.ShowInfo();

ps5.HealSomebody(ps1);

ps1.ShowInfo();

Console.WriteLine();

Console.ReadKey();