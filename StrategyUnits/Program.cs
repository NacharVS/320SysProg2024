using StrategyUnits;

Barracks barracks = new();
Footman footman = barracks.CreateFootman("Hugo");
Berserk berserk = barracks.CreateBerserk("Ivan");
Healer healer = new Healer("Insaf");
footman.ShowInfo();
berserk.ShowInfo();

footman.Attack(berserk);

berserk.ShowInfo();

berserk.Attack(footman);

berserk.Attack(footman);

healer.HealSomebody(berserk);

berserk.ShowInfo();

footman.Attack(berserk);

berserk.ShowInfo();





