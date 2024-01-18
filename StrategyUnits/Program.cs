using StrategyUnits;
using System.Runtime.Serialization.Formatters;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Paladin paladin = new Paladin();
Healer healer = new Healer();
Altar altar = new Altar();
ps1.HealthChangedEvent += Method;
ps1.HealthIncreasedEvent += Method1;
ps1.HealthDecreasedEvent += Method2;
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//ps1.Collect_food();
//ps1.Collect_wood();
//ps1.ShowInfo();

//healer.Heal(ps1);
//ps1.ShowInfo();
//Console.WriteLine("////////////////////////////////////");


ps1.ShowInfo();
healer.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
healer.Heal(ps1);
ps1.ShowInfo();

altar.RecHeal(healer);


static void Method(int numbre)
{
    Console.WriteLine($"Здоровье изменилось.CurrentHealth {numbre}");
}

static void Method1(int num)
{
    Console.WriteLine($"Здоровье уменьшилось на {num}");
}

static void Method2(int num1)
{
    Console.WriteLine($"Здоровье увеличилось на {num1}");
}




