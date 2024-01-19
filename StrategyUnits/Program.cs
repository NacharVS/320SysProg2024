using StrategyUnits;

//Footman footman = new Footman();
//Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Cleric cleric = new Cleric();
Cleric cleric2 = new Cleric();
Palladin palladin = new Palladin();
Altar altar = new Altar();

Barracks barracks = new Barracks();
Footman footman = barracks.CreateFootman();

Console.WriteLine("About Altar: ");
altar.ShowInfoAboutAltar();

static void AttackVoid(int damage, int health, string name_n, string name_p)
{
    Console.WriteLine($"{name_n} maked attack on {name_p}. {name_p} had damage = {damage}. Him name: {name_p} Health: {health}.");
}

static void HillVoid(int manna, int health, string nameHiller, string nameHill)
{
    Console.WriteLine($"{nameHiller} restored health {nameHill} for {health}.Manna {nameHiller}: {manna}");
}
//Console.WriteLine("Begin:");
//ps1.ShowInfo();
//footman.ShowInfo();
//Console.WriteLine("First Cleric");
//cleric.ShowInfo();
//cleric.GetInfoCleric();
//Console.WriteLine("Second Cleric");
//cleric2.ShowInfo();
//cleric2.GetInfoCleric();

//Console.WriteLine("Attack first Cleric");
//footman.InflictDamage(cleric);
//Console.WriteLine("First Cleric after attack");
//cleric.ShowInfo();
//cleric.GetInfoCleric();


//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//Console.WriteLine("First Cleric after attack");
//cleric.ShowInfo();
//cleric.GetInfoCleric();

//Console.WriteLine("Attack second cleric");
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//cleric2.ShowInfo();
//cleric2.GetInfoCleric();

//Console.WriteLine("First Cleric try to hill somebody");
//cleric.HillOthers(cleric2);
//Console.WriteLine("Information about first cleric");
//cleric.ShowInfo();
//cleric.GetInfoCleric();
//Console.WriteLine("Information about second cleric");
//cleric2.ShowInfo();
//cleric2.GetInfoCleric();


//Console.WriteLine("First Cleric hill himself");
//cleric.HillMyself(cleric);

//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric); 
//footman.InflictDamage(cleric); 
//footman.InflictDamage(cleric);
//footman.InflictDamage(cleric);

//cleric.HillMyself(cleric);
//cleric.ShowInfo();
//cleric.GetInfoCleric();

//Console.WriteLine("Attack on first died Cleric: ");
//footman.InflictDamage(cleric);

//Console.WriteLine("Died Cleric try to hill other: ");
//cleric.HillOthers(cleric2);

Console.WriteLine("Begin:");

footman.InflictAttackEvent += AttackVoid;

footman.InflictAttackEvent += HillVoid;