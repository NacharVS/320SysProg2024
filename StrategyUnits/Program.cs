using System;
using StrategyUnits;

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

//footman.ShowInfo();
//cleric.ShowInfo();
//paladin.ShowInfo();
//paladin.HealthDecreasedEvent += InfoHealthIncreased;
//paladin.HealthIncreasedEvent += InfoHealthIncreased;

//paladin.MannaDecreasedEvent += InfoMannaLess;
//Console.WriteLine("Footman attack");
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);

//paladin.HealthIncreasedEvent += InfoHealthIncreased;
//paladin.MannaDecreasedEvent += InfoMannaLess;

//Console.WriteLine("Hill");

//paladin.HealthIncreasedEvent += InfoHealthIncreased;
//paladin.MannaDecreasedEvent += InfoMannaLess;
//cleric.HealthIncreasedEvent += InfoHealthIncreased;
//cleric.MannaDecreasedEvent += InfoMannaLess;



////berserker.ShowInfo();
////berserker.HealthDecreasedEvent += InfoHealthIncreased;
////berserker.HealthIncreasedEvent += InfoHealthIncreased;
////berserker.InflictDamage(footman);

////berserker.HealthIncreasedEvent += InfoHealthIncreased;
////paladin.ShowInfo();
//zealotKnight.ShowInfo();
//forge.UpdateLevelWeapon(paladin);
////forge.UpdateLevelWeapon(zealotKnight);
////forge.UpdateLevelWeapon(zealotKnight);
////forge.UpdateLevelArmor(zealotKnight);
////forge.UpdateLevelArmor(paladin);
////forge.UpdateLevelArmor(paladin);
////forge.UpdateLevelArmor(paladin);
////zealotKnight.ShowInfo();
////paladin.ShowInfo();
//////footman.HealthDecreasedEvent += AttackVoid;

////cleric.ShowInfo();
////footman.InflictAttackEvent += AttackVoid;
////footman.InflictAttackEvent += AttackVoid;
//altar.ShowInfoAboutAltar();
////paladin = altar.CreatePalladin();
////paladin.ShowInfo();



//footman.HealthDecreasedEvent += InfoHealthIncreased;
//footman.HealthIncreasedEvent += InfoHealthIncreased;

//cleric.HealthDecreasedEvent += InfoHealthIncreased;
//cleric.HealthIncreasedEvent += InfoHealthIncreased;


//berserker.HealthDecreasedEvent += InfoHealthIncreased;
//berserker.HealthIncreasedEvent += InfoHealthIncreased;

////paladin.ShowInfo();
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);


//berserker.InflictDamage(footman);
//berserker.HealthDecreasedEvent += InfoHealthIncreased;

//berserker.Rage(cleric);


//cleric.ShowInfo();
//paladin.ShowInfo();
//cleric.HillOthers(paladin);


//paladin.ShowInfo();
//berserker.ShowInfo();
//footman.ShowInfo();
//forge.UpdateLevelArmor(paladin);

//berserker.Rage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);


//berserker.Rage(cleric);
//berserker.ShowInfo();

Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1");
Cleric cleric_v = altar.CreateCleric();
cleric_v.ShowInfo();
Berserker berserker_v = barrack.CreateBerserker();
berserker_v.ShowInfo();
Footman footman_v = barrack.CreateFootman();
footman_v.ShowInfo();

cleric_v.HealthDecreasedEvent += InfoHealthIncreased;
cleric_v.HealthIncreasedEvent += InfoHealthIncreased;
footman_v.HealthDecreasedEvent += InfoHealthIncreased;
footman_v.HealthIncreasedEvent += InfoHealthIncreased;
berserker_v.HealthDecreasedEvent += InfoHealthIncreased;
berserker_v.HealthIncreasedEvent += InfoHealthIncreased;
cleric_v.MannaDecreasedEvent += InfoMannaLess;
cleric_v.MannaIncreasedEvent += InfoMannaLess;


berserker_v.InflictDamage(footman_v);
berserker_v.InflictDamage(footman_v);
footman_v.InflictDamage(berserker_v);
footman_v.ShowInfo();

Console.WriteLine("\nПРОБА ХИЛЛА");
cleric_v.HillOthers(footman_v);
footman_v.ShowInfo();
cleric_v.GetInfoManna();

Forge forge_v =  new Forge();
forge_v.UpdateLevelWeapon(footman_v);

berserker_v.ShowInfo();
paladin.HollyArmorAttack(berserker_v);
berserker_v.ShowInfo();

cleric_v.GetInfoManna();
altar.RegenerationManna(cleric_v);
cleric_v.GetInfoManna();
altar.ShowInfoAboutAltar();

paladin.ShowInfo();
forge_v.UpdateLevelWeapon(paladin);

// add next level
forge_v.UpdateLevelWeapon(paladin);

// add max level
forge_v.UpdateLevelWeapon(paladin);

// add level armor
paladin.ShowInfo();
forge_v.UpdateLevelArmor(paladin);
forge_v.UpdateLevelArmor(paladin);


static void InfoMannaLess (int health, string name, int manna)
{
    Console.WriteLine($"Health: {health} Name: {name} Manna: {manna}");
}

static void InfoHealthIncreased (int health, string name, int manna, int guard)
{
    Console.WriteLine($"Name: {name} Health: {health} Manna: {manna} Guard: {guard}");
}

