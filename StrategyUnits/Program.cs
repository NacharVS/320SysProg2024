using StrategyUnits;
Barrack barrack = new Barrack();
<<<<<<< Updated upstream
Altar altar = new Altar();
Footman recruit = barrack.CreateRecruit();
=======
Forge forge = new Forge();
Altar altar = new Altar();
Berserker berserker = barrack.CreateBerserker();
>>>>>>> Stashed changes
Footman footman = barrack.CreateFootman();
Cleric cleric = altar.CreateCleric();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();
zealotKnight.ShowInfo();
<<<<<<< Updated upstream
=======
forge.WeaponUpgrade(paladin);
forge.WeaponUpgrade(zealotKnight);
forge.WeaponUpgrade(zealotKnight);
forge.ArmorUpgrade(zealotKnight);
forge.ArmorUpgrade(paladin);
forge.ArmorUpgrade(paladin);
forge.ArmorUpgrade(paladin);
zealotKnight.ShowInfo();
>>>>>>> Stashed changes
paladin.ShowInfo();
footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

cleric.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
cleric.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;
<<<<<<< Updated upstream

paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

footman.Attack(footman);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
cleric.HealSomebody(footman);
footman.Attack(cleric);
cleric.HealSomebody(cleric);
altar.RestoreEP(cleric);
cleric.HealSomebody(cleric);
paladin.HolyFire(footman);
=======
>>>>>>> Stashed changes

paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

<<<<<<< Updated upstream
=======
berserker.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
berserker.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
footman.Attack(paladin);
berserker.Attack(footman);
footman.Attack(berserker);
berserker.Attack(footman);
cleric.HealSomebody(paladin);
footman.Attack(berserker);
footman.Attack(cleric);
cleric.HealSomebody(cleric);
altar.RestoreEP(cleric);
cleric.HealSomebody(cleric);
cleric.Attack(footman);
cleric.HealSomebody(footman);

>>>>>>> Stashed changes
static void ShowInformationAfterLossOfHealth(string? name, double health, double difference, double protection, double maxHealth)
{
    Console.WriteLine($"\u001b[31m{name} получил урон, здоровье уменьшилось на {difference}\u001b[0m \u001b[36m(поглащено урона: {protection}\u001b[0m),\u001b[31m текущее здоровье: {health}/{maxHealth}\u001b[0m");
}
static void ShowInformationAfterHealthIsRestored(string? name, double health, double difference, double protection, double maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Green;
<<<<<<< Updated upstream
    Console.WriteLine($"{name} был излечн, здоровье увеличилось на {difference}, текущее здоровье: {health}/{maxHealth}, защита: {protection}");
=======
    Console.WriteLine($"{name} был излечён, здоровье увеличилось на {difference}, текущее здоровье: {health}/{maxHealth}, защита: {protection}");
>>>>>>> Stashed changes
    Console.ForegroundColor = ConsoleColor.White;

}

void ShowInformationAfterLossOfEnergy(string name, double energy, double difference, double maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия уменьшена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}

void ShowInformationAfterEnergyIsRestored(string name, double energy, double difference, double maxEnergy)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{name} энергия увеличена на {difference}, текущая энергия: {energy}/{maxEnergy}");
    Console.ForegroundColor = ConsoleColor.White;
}
