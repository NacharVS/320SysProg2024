using StrategyUnits;
using StrategyUnits.Extra;
using System.Text;
using System.Xml.Linq;

//static void MethodDamage(string? name, int health, int health1, int maxHealth, int damage)
//{
//    Console.WriteLine($"{name} аттаковал. Урон противнику составил {damage}.\n");
//}

//static void MethodHeal(string? name, int health, int health1, int maxHealth, int damage)
//{
//    Console.WriteLine($"{name} получил урон {damage}. Текущее здоровье: {health}/{maxHealth}.\n");
//}

static void MethodLossHealth(string? name, int health, int health1, int maxHealth)
{
    Console.WriteLine($"{name} получил урон. Текущее здоровье: {health}/{maxHealth}.");
}

static void MethodGetHealth(string? name, int health, int health1, int maxHealth)
{
    Console.WriteLine($"{name} был вылечен. Текущее здоровье: {health}/{maxHealth}.");
}

static void MethodLossEnergy(string? name, int energy, int energy1, int maxEnergy)
{
    Console.WriteLine($"{name} потратил энергию. Текущая энергия: {energy}/{maxEnergy}.");
}

static void MethodGetEnergy(string? name, int energy, int energy1, int maxEnergy)
{
    Console.WriteLine($"{name} получил энергию. Текущая энергия: {energy}/{maxEnergy}.");
}

Barracks barrack = new Barracks();
Console.WriteLine("Был создан барак.");
Forge forge = new Forge();
Console.WriteLine("Была создана кузница.");
Altar altar = new Altar("Алтарь", 100, 100);
Console.WriteLine("Был создан алтарь.");
Berserker berserker = barrack.CreateBerserker();
Console.WriteLine("Был создан Берсерк.");
berserker.ShowInfo();
Footman footman = barrack.CreateFootman();
Console.WriteLine("Был создан Футман.");
footman.ShowInfo();
Paladin paladin = altar.CreatePaladin();
Console.WriteLine("Был создан Паладин.");
paladin.ShowInfo();
Cleric cleric = altar.CreateCleric();
Console.WriteLine("Был создан Клерик.");
cleric.ShowInfo();
ZealotKnight zealotKnight = altar.CreateZealotKnight();
Console.WriteLine("Был создан ЗилотНайт.");
zealotKnight.ShowInfo();


footman.HealthIncreasedEvent += MethodGetHealth;
footman.HealthDecreasedEvent += MethodLossHealth;
berserker.HealthIncreasedEvent += MethodGetHealth;
berserker.HealthDecreasedEvent += MethodLossHealth;
paladin.HealthIncreasedEvent += MethodGetHealth;
paladin.HealthDecreasedEvent += MethodLossHealth;
zealotKnight.HealthIncreasedEvent += MethodGetHealth;
zealotKnight.HealthDecreasedEvent += MethodLossHealth;

zealotKnight.EnergyDecreasedEvent += MethodLossEnergy;
zealotKnight.EnergyIncreasedEvent += MethodGetEnergy;
cleric.EnergyDecreasedEvent += MethodLossEnergy;
cleric.EnergyIncreasedEvent += MethodGetEnergy;
paladin.EnergyDecreasedEvent += MethodLossEnergy;
paladin.EnergyIncreasedEvent += MethodGetEnergy;
Console.WriteLine();
Console.WriteLine("НАЧАЛО. ЗИЛОТ АТАКОВАЛ ФУТМАНА.");
zealotKnight.Attack(footman);
Console.WriteLine();
Console.WriteLine("ИНФОРМАЦИЯ О ФУТМАНЕ.");
footman.ShowInfo();
Console.WriteLine("НАЧАЛО.");
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
footman.Attack(zealotKnight);
zealotKnight.ShowInfo();
zealotKnight.Prayer();
zealotKnight.ShowInfo();
Console.WriteLine();
paladin.FireAttack(zealotKnight);
zealotKnight.ShowInfo();
Console.WriteLine();
Console.WriteLine("МАГИЧЕСКАЯ АТАКА.");
paladin.ShowInfo();
zealotKnight.ShowInfo();
paladin.MagicAttack(zealotKnight);
paladin.ShowInfo();
zealotKnight.ShowInfo();
Console.WriteLine();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
zealotKnight.Attack(paladin);
paladin.ShowInfo();
Console.WriteLine();
forge.WeaponUpgrade();
forge.ArmorUpgrade();