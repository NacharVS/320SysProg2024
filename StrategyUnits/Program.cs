using StrategyUnits;

Console.WriteLine("...");
Console.WriteLine("\"Create some persons\"");
Footman footman = new Footman(13, 60);
Footman footman2 = new Footman(15, 50);
Peasant ps1 = new Peasant();
Healer healer = new Healer(50, 40);
Paladin paladin = new Paladin(50, 14);
Altar altar = new Altar(2000);

altar.ShowInf();
ps1.ShowInfo();
healer.ShowInfo();
footman.ShowInfo();
paladin.ShowInfo();
//footman.ShowInfo();
//footman2.ShowInfo();
//Console.WriteLine("...");
//Console.WriteLine("\"Try to murder footman...\"");
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();
//footman.InflictDamage(footman2);
//footman2.ShowInfo();

//Console.WriteLine("...");
//Console.WriteLine("\"Doing something))\"");
//ps1.Move();
//ps1.Build();

//Console.WriteLine("...");
//Console.WriteLine("\"True crime\"");
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//ps1.ShowInfo();

//Console.WriteLine("...");
//Console.WriteLine("\"Healing, ura\"");
//footman.InflictDamage(healer);
//healer.ShowInfo();
//healer.ToHeal(ps1);
//ps1.ShowInfo();

//Console.WriteLine("...");
//Console.WriteLine("\"SelfHealing, ura\"");
//healer.ToHeal(healer);

Console.WriteLine("...");
Console.WriteLine("\"Another true crime\"");
//ps1.HealthChangeEvent += Method;
ps1.HealthLowEvent += LowHealth;
ps1.HealthHighEvent += HighHealth;
healer.HealthLowEvent += LowHealth;
healer.HealthHighEvent += HighHealth;
//footman.InflictDamage(ps1);
paladin.InflictDamage(ps1);
paladin.InflictDamage(healer);
////footman.InflictDamage(ps1);
////footman.InflictDamage(ps1);
////footman.InflictDamage(ps1);
ps1.ShowInfo();
healer.ToHeal(healer);
healer.ToHeal(ps1);

//Console.WriteLine("...");
//Console.WriteLine("\"Peasant can collect something\"");
//ps1.Collecting();
//ps1.Collecting();
//ps1.Collecting();

altar.RecoverMana(healer);
ps1.ShowInfo();
healer.ShowInfo();
footman.ShowInfo();
paladin.ShowInfo();
altar.ShowInf();
//Delegates

//static void Method(int number)
//{
//    Console.Write($"Health has change. Current health {number}   ");
//}
static void LowHealth(int number, int n)
{
    Console.WriteLine($"Health decreased | Damage - {n} | Current health {number}");
}
static void HighHealth(int number, int n)
{
    Console.WriteLine($"Health increased | Heal + {n} | Current health {number}.");
}