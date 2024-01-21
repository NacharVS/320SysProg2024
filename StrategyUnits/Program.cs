using System;
using StrategyUnits;

//Footman footman = new Footman();
//Footman footman2 = new Footman();
//Peasant ps1 = new Peasant();
//Cleric cleric = new Cleric();
//Cleric cleric2 = new Cleric();
//Palladin palladin = new Palladin();
//Altar altar = new Altar();

//Barracks barracks = new Barracks();
//Footman footman = barracks.CreateFootman();

//Console.WriteLine("About Altar: ");
//altar.ShowInfoAboutAltar();

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

//footman.InflictAttackEvent += AttackVoid;

//footman.InflictAttackEvent += HillVoid;

Barracks barrack = new Barracks();
Forge forge = new Forge();
Altar altar = new Altar();
Berserker berserker = barrack.CreateBerserker();
Footman footman = barrack.CreateFootman();
Cleric cleric = altar.CreateCleric();
Palladin paladin = altar.CreatePalladin();
ZeelotKnight zealotKnight = altar.CreateZeelotKnight();


//forge.UpdateLevelWeapon(zealotKnight);

footman.ShowInfo();
cleric.ShowInfo();
paladin.ShowInfo();
paladin.HealthDecreasedEvent += InfoHealthIncreased;
paladin.HealthIncreasedEvent += InfoHealthIncreased;

paladin.MannaDecreasedEvent += InfoMannaLess;
Console.WriteLine("Footman attack");
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);

paladin.HealthIncreasedEvent += InfoHealthIncreased;
paladin.MannaDecreasedEvent += InfoMannaLess;

Console.WriteLine("Hill");
cleric.HillOthers(paladin);
paladin.HealthIncreasedEvent += InfoHealthIncreased;
paladin.MannaDecreasedEvent += InfoMannaLess;
cleric.HealthIncreasedEvent += InfoHealthIncreased;
cleric.MannaDecreasedEvent += InfoMannaLess;


//berserker.ShowInfo();
//berserker.HealthDecreasedEvent += InfoHealthIncreased;
//berserker.HealthIncreasedEvent += InfoHealthIncreased;
//berserker.InflictDamage(footman);

//berserker.HealthIncreasedEvent += InfoHealthIncreased;
//paladin.ShowInfo();
//zealotKnight.ShowInfo();
//forge.UpdateLevelWeapon(paladin);
//forge.UpdateLevelWeapon(zealotKnight);
//forge.UpdateLevelWeapon(zealotKnight);
//forge.UpdateLevelArmor(zealotKnight);
//forge.UpdateLevelArmor(paladin);
//forge.UpdateLevelArmor(paladin);
//forge.UpdateLevelArmor(paladin);
//zealotKnight.ShowInfo();
//paladin.ShowInfo();
////footman.HealthDecreasedEvent += AttackVoid;

//cleric.ShowInfo();
//footman.InflictAttackEvent += AttackVoid;
//footman.InflictAttackEvent += AttackVoid;

//altar.ShowInfoAboutAltar();
//paladin = altar.CreatePalladin();
//paladin.ShowInfo();

//cleric.HillOthers(paladin);
//paladin.MannaDecreasedEvent += InfoMannaLess;

//forge.UpdateLevelWeapon(paladin);
//forge.UpdateLevelWeapon(zealotKnight);
//forge.UpdateLevelWeapon(zealotKnight);
//forge.UpdateLevelArmor(zealotKnight);
//forge.UpdateLevelArmor(paladin);
//forge.UpdateLevelArmor(paladin);
//forge.UpdateLevelArmor(paladin);
//zealotKnight.ShowInfo();
//paladin.ShowInfo();

//footman.HealthDecreasedEvent += InfoHealthIncreased;
//footman.HealthIncreasedEvent += InfoHealthIncreased;

//cleric.HealthDecreasedEvent += InfoHealthIncreased;
//cleric.HealthIncreasedEvent += InfoHealthIncreased;
//cleric.MannaIncreasedEvent += InfoMannaLess;
//cleric.MannaDecreasedEvent += InfoMannaLess;

//paladin.HealthDecreasedEvent += InfoHealthIncreased;
//paladin.HealthIncreasedEvent += InfoHealthIncreased;
//paladin.MannaIncreasedEvent += InfoMannaLess;
//paladin.MannaDecreasedEvent += InfoMannaLess;

berserker.HealthDecreasedEvent += InfoHealthIncreased;
berserker.HealthIncreasedEvent += InfoHealthIncreased;

//paladin.ShowInfo();
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//paladin.ShowInfo();
//paladin.HealthDecreasedEvent += InfoHealthIncreased;

//berserker.InflictDamage(footman);
//footman.InflictDamage(berserker);
//berserker.InflictDamage(footman);
//cleric.HillOthers(paladin);
//paladin.ShowInfo();
//paladin.HealthIncreasedEvent += InfoHealthIncreased;

//cleric.HillOthers(footman);

static void InfoMannaLess (int health, string name, int manna)
{
    Console.WriteLine($"Health: {health} Name: {name} Manna: {manna}");
}

static void InfoHealthIncreased (int health, string name, int manna, int guard)
{
    Console.WriteLine($"Name: {name} Health: {health} Manna: {manna} Guard: {guard}");
}

