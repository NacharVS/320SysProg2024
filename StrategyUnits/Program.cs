using StrategyUnits;

Footman footman1 = new Footman();
Peasant ps1 = new Peasant();

// Footman.
footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// Health can't be above zero.
footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);
footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// Can't deal damage to dead units.
footman1.ShowInfo();
ps1.ShowInfo();

footman1.InflictDamage(ps1);

ps1.ShowInfo();

Console.WriteLine();

// Peasant can't heal himself dead.
ps1.ShowInfo();

ps1.HealSelf();

ps1.ShowInfo();

Console.WriteLine();

// Peasant heal.
Footman footman2 = new Footman();
Peasant ps2 = new Peasant();

footman2.ShowInfo();
ps2.ShowInfo();

footman2.InflictDamage(ps2);
ps2.ShowInfo();

ps2.HealSelf();
ps2.ShowInfo();

Console.WriteLine();

// Peasant cant't heal self to more than max health.
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

// Peasant heal somebody.
Peasant ps3 = new Peasant();

ps3.ShowInfo();

footman2.InflictDamage(ps3);
ps3.ShowInfo();

ps2.HealSomebody(ps3);
ps3.ShowInfo();

Console.WriteLine();

// Peasant cant't heal sb to more than max health
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

// Peasant can't heal sb dead.
ps5.ShowInfo();
ps1.ShowInfo();

ps5.HealSomebody(ps1);

ps1.ShowInfo();

Console.WriteLine();

Console.ReadKey();