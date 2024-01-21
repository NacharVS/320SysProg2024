using StrategyUnits;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("...");
Console.WriteLine("\"Create some persons\"");
Barracks barracks = new Barracks();
//Footman recruit = barracks.CreateRecruit();
Footman footman = barracks.CreateFootman();
Footman berserker = barracks.CreateBerserker();
//Peasant ps1 = new Peasant();
Healer healer = new Healer();
Paladin paladin = new Paladin();
//Altar altar = new Altar();

//altar.ShowInf();
//ps1.ShowInfo();
healer.ShowInfo();
//recruit.ShowInfo();
footman.ShowInfo();
berserker.ShowInfo();
paladin.ShowInfo();

//altar.RecoverMana(healer);
////footman.ShowInfo();
////footman2.ShowInfo();
////Console.WriteLine("...");
////Console.WriteLine("\"Try to murder footman...\"");
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();
////footman.InflictDamage(footman2);
////footman2.ShowInfo();

////Console.WriteLine("...");
////Console.WriteLine("\"Doing something))\"");
////ps1.Move();
////ps1.Build();

////Console.WriteLine("...");
////Console.WriteLine("\"True crime\"");
////ps1.ShowInfo();
////footman.InflictDamage(ps1);
////ps1.ShowInfo();

////Console.WriteLine("...");
////Console.WriteLine("\"Healing, ura\"");
////footman.InflictDamage(healer);
////healer.ShowInfo();
////healer.ToHeal(ps1);
////ps1.ShowInfo();

////Console.WriteLine("...");
////Console.WriteLine("\"SelfHealing, ura\"");
////healer.ToHeal(healer);

//Console.WriteLine("...");
//Console.WriteLine("\"Another true crime\"");
//ps1.HealthChangeEvent += Method;
//ps1.HealthLowEvent += LowHealth;
//ps1.HealthHighEvent += HighHealth;
//healer.HealthLowEvent += LowHealth;
//healer.HealthHighEvent += HighHealth;
footman.HealthLowEvent += LowHealth;
footman.HealthHighEvent += HighHealth;
berserker.HealthLowEvent += LowHealth;
berserker.HealthHighEvent += HighHealth;
berserker.StartRageEvent += StRage;

paladin.HealthLowEvent += LowHealth;
paladin.HealthHighEvent += HighHealth;
paladin.StartRageEvent += StRage;
////footman.InflictDamage(ps1);
//paladin.InflictDamage(ps1);
//paladin.InflictDamage(healer);
//////footman.InflictDamage(ps1);
//////footman.InflictDamage(ps1);
//////footman.InflictDamage(ps1);
//ps1.ShowInfo();
//healer.ToHeal(healer);
//healer.ToHeal(ps1);
//healer.ShowInfo();

////Console.WriteLine("...");
////Console.WriteLine("\"Peasant can collect something\"");
////ps1.Collecting();
////ps1.Collecting();
////ps1.Collecting();

//altar.RecoverMana(healer);
//ps1.ShowInfo();
//healer.ShowInfo();
//footman.ShowInfo();
//paladin.ShowInfo();
//altar.ShowInf();

berserker.ProtectSuit();
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);


footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
berserker.ShowInfo();

Console.WriteLine("...");
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
paladin.Pray();
Console.WriteLine("...");
paladin.HollyFire(footman);
//Delegates

//static void Method(int number)
//{
//    Console.Write($"Health has change. Current health {number}   ");
//}
static void LowHealth(int number, int n, string? name)
{
    Console.WriteLine($"{name}'s health decreased | Damage: - {n} | Current health: {number}");
}
static void HighHealth(int number, int n, string? name)
{
    Console.WriteLine($"{name}'s health increased | Heal: + {n} | Current health: {number}.");
}
static void StRage(int health)
{
    Console.WriteLine($"Health is low then 50%. Current health: {health}.");
}