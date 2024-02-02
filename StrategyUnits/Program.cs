using StrategyUnits.Units;
using StrategyUnits.Units.Buildings;
using System;

var barrcak = new Barracks();
var altal = new Altar("Священный");
var recruit = barrcak.CreateRecruit("Helldem");


var peasant = new Peasant(25,"Крестьянин",5);
var berserk = barrcak.CreateBersekr("Ramil");
berserk.ShowInformation();
var foot = barrcak.CreateFootman("Kirill Osipov");
foot.ShowInformation();

var paladin = altal.CreatePaladin("Тот самый");
paladin.ShowInformation();
peasant.StartWork();
peasant.ShowInformation();
peasant.EndWork();
peasant.ShowInformation();
