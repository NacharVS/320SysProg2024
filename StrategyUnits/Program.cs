﻿using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Cleric cleric = new Cleric();

ps2.ShowInfo();
//footman.Attack(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
footman.Attack(ps2);
ps2.ShowInfo();

cleric.HealOther(ps2);
cleric.ShowInfo();
cleric.ShowInfoEnergy();
cleric.ReconstructionEnergy();
cleric.ShowInfoEnergy();
ps2.ShowInfo();

ps2.Harvest();
ps2.CleaningTheArea();
ps2.EndOfWork();
ps2.CleaningTheArea();
