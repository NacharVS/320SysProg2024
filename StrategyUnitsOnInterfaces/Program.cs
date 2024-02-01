using StrategyUnitsOnInterfaces;
Cleric cleric = new Cleric(10, 50);
Footman footman = new Footman(100, 23, 44, 10);
Footman footman2 = new Footman(100, 23, 44, 10);
Peasant peasant = new Peasant(100);
Forge forge = new Forge();

peasant.ShowInfo();
footman.Attack(peasant);
peasant.ShowInfo();
cleric.Heal(peasant);
peasant.ShowInfo();
forge.UpgradeArmor(footman, footman2);
forge.UpgradeArmor(footman, footman2);
forge.UpgradeArmor(footman, footman2);
forge.UpgradeArmor(footman, footman2);
