using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Cleric cleric = new Cleric();
Altar altar = new Altar();
Paladin paladin = new Paladin(2);

footman2.HealthChangedEvent += ShowInfo;
cleric.HealthChangedEvent += ShowInfo;
paladin.HealthChangedEvent += ShowInfo;
footman.Attack(footman2);
cleric.HealSomebody(footman2);
footman.Attack(cleric);
cleric.HealSelf(cleric);
altar.RestoreEP(cleric);
cleric.HealSelf(cleric);
paladin.MagicAttack(footman2);


static void ShowInfo(string? name, int health)
{
    Console.WriteLine($"Health changed {name} to {health}");
}
