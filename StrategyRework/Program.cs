using StrategyRework;

CityBarracs barracs = new CityBarracs();
Peasant ps = barracs.CreatePeasant();
Console.WriteLine(ps.Name + ps.Health);