using StrategyUnits;
using StrategyUnits.Units;

Barracks barracks = new();
Footman footman = barracks.CreateFootman("Hugo");
Berserk berserk = barracks.CreateBerserk("Ivan");
Healer healer = barracks.CreateHealer("Insaf");
ZealotKnight zknight = barracks.CreateZKnight("Kirill");
Paladin paladin = barracks.CreatePaladin("Almir");
Forge forge = new Forge();

List<MilitaryUnit> warriors = barracks.warriors;

berserk.ShowInfo();
paladin.ShowInfo();

forge.UpgradeWeapons(warriors);

forge.UpgradeWeapons(warriors);

forge.UpgradeWeapons(warriors);

forge.UpgradeArmor(warriors);
forge.UpgradeArmor(warriors);
forge.UpgradeArmor(warriors);

berserk.ShowInfo();
paladin.ShowInfo();


