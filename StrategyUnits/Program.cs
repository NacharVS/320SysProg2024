using StrategyUnits;

Footman footman = new Footman();
Peasant peasant = new Peasant();
Healer healer = new Healer();
Paladin paladin = new Paladin();
Altar altar = new Altar();

healer.ShowInfo();
paladin.ShowInfo();
paladin.FireBall(healer);
healer.ShowInfo();
paladin.ShowInfo();
altar.RestoreMana(paladin);
paladin.ShowInfo();