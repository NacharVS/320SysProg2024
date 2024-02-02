using StrategyUnits.Units;
using StrategyUnits.Units.Buildings;
using System;

var barrack = new Barracks();
var altar = new Altar("Священный");


var peasant = new Peasant(25,"Крестьянин",5);
var berserk = barrack.CreateBersekr("Ramil");
berserk.ShowInformation();
var foot = barrack.CreateFootman("Kirill Osipov");
foot.ShowInformation();

var paladin = altar.CreatePaladin("Тот самый");
paladin.ShowInformation();
peasant.StartWork();
peasant.ShowInformation();
peasant.EndWork();
peasant.ShowInformation();
paladin.MagicAttack(foot);
peasant.ShowInformation();


