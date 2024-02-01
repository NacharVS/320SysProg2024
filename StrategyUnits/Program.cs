using System;
using StrategyUnits;

Console.WriteLine("Begin:");

//footman.InflictAttackEvent += AttackVoid;

//footman.InflictAttackEvent += HillVoid;

Barracks barrack = new Barracks();
Forge forge = new Forge();
Altar altar = new Altar(1000, "Altar 1", 1010);
Berserker berserker = barrack.CreateBerserker();
Footman footman = barrack.CreateFootman();
Cleric cleric = altar.CreateCleric();
Palladin paladin = altar.CreatePalladin();
ZeelotKnight zealotKnight = altar.CreateZeelotKnight();


//forge.UpdateLevelWeapon(zealotKnight);

//footman.ShowInfo();
//cleric.ShowInfo();
//paladin.ShowInfo();
altar.MannaDecreasedEvent += InfoMannaGrow;
altar.MannaIncreasedEvent += InfoMannaGrow;
paladin.HealthDecreasedEvent += InfoHealthIncreased;
paladin.HealthIncreasedEvent += InfoHealthIncreased;

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

paladin.HealthIncreasedEvent += InfoHealthIncreased;
paladin.MannaDecreasedEvent += InfoMannaGrow;
cleric.HealthIncreasedEvent += InfoHealthIncreased;
cleric.MannaDecreasedEvent += InfoMannaGrow;



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




























Console.WriteLine("");
Cleric cleric_v = altar.CreateCleric();
cleric_v.ShowInfo();
Console.WriteLine(" ");

Berserker berserker_v = barrack.CreateBerserker();
berserker_v.ShowInfo();
Console.WriteLine(" ");

Footman footman_v = barrack.CreateFootman();
footman_v.ShowInfo();
Console.WriteLine(" ");

Palladin palladin_v = altar.CreatePalladin();
palladin_v.ShowInfo();
Console.WriteLine(" ");

cleric_v.HealthDecreasedEvent += InfoHealthDecreased;
cleric_v.HealthIncreasedEvent += InfoHealthIncreased;
footman_v.HealthDecreasedEvent += InfoHealthDecreased;
footman_v.HealthIncreasedEvent += InfoHealthIncreased;
berserker_v.HealthDecreasedEvent += InfoHealthDecreased;
berserker_v.HealthIncreasedEvent += InfoHealthIncreased;
palladin_v.HealthDecreasedEvent += InfoHealthDecreased;
palladin_v.HealthIncreasedEvent += InfoHealthIncreased;


//cleric_v.MannaDecreasedEvent += ;
cleric_v.MannaIncreasedEvent += InfoMannaGrow;
palladin_v.MannaIncreasedEvent += InfoMannaGrow;
cleric_v.MannaDecreasedEvent += InfoMannaGrow;
palladin_v.MannaDecreasedEvent += InfoMannaGrow;

void InfoMannaGrow(int manna, string? name, int change, int maxManna)
{
    Console.WriteLine($"About unit: \n Manna: {manna}\n Name: {name}\n Change: {change}\n MaxManna: {maxManna}");
}

Console.WriteLine(" ");
Console.WriteLine("Berserker attack Footman ");
berserker_v.InflictDamage(footman_v);
berserker_v.InflictDamage(footman_v);
Console.WriteLine("Footman attack Berserker ");
footman_v.InflictDamage(berserker_v);
footman_v.ShowInfo();


Console.WriteLine(" ");
Console.WriteLine("\nПРОБА ХИЛЛА");
cleric_v.HillOthers(footman_v);
footman_v.ShowInfo();
cleric_v.ShowInfo();
Console.WriteLine(" ");
Forge forge_v =  new Forge();
forge_v.UpdateLevelWeapon();

berserker_v.ShowInfo();
paladin.HollyArmorAttack(berserker_v);
berserker_v.ShowInfo();


Console.WriteLine(" ");

Console.WriteLine(" Begin hill. Info about character. ");
cleric_v.ShowInfo();
berserker_v.ShowInfo();
altar.ShowInfoAboutAltar();
Console.WriteLine("Cleric hill Berserker: ");
cleric_v.HillOthers(berserker_v);
berserker_v.ShowInfo();
cleric_v.ShowInfo();

Console.WriteLine(" ");
Console.WriteLine("About Altar. ");
cleric_v.ShowInfo();
altar.RegenerationManna(cleric_v);
//altar.DoManna();
altar.ShowInfoAboutAltar();
Console.WriteLine("After Altar. ");
cleric_v.ShowInfo();


forge_v.UpdateLevelWeapon();
forge_v.UpdateLevelWeapon();
forge_v.UpdateLevelWeapon();


//// add next level
//forge_v.UpdateLevelWeapon(paladin);

//// add max level
//forge_v.UpdateLevelWeapon(paladin);

//// add level armor
//paladin.ShowInfo();
//forge_v.UpdateLevelArmor(paladin);
//forge_v.UpdateLevelArmor(paladin);

//cleric_v.GetInfoManna();
//cleric_v.ShowInfo();
Console.WriteLine("Hill himself");
cleric_v.HillMyself();
cleric_v.ShowInfo();

berserker_v.ShowInfo();
footman_v.InflictDamage(berserker_v);
footman_v.InflictDamage(berserker_v);
footman_v.InflictDamage(berserker_v);
footman_v.InflictDamage(berserker_v);
footman_v.InflictDamage(berserker_v);
footman_v.InflictDamage(berserker_v);
//footman_v.InflictDamage(berserker_v);
//footman_v.InflictDamage(berserker_v);
Console.WriteLine(" ");
//berserker_v.Rage(footman_v);
berserker_v.ShowInfo();

footman_v.InflictDamage(palladin_v);
footman_v.InflictDamage(palladin_v);
footman_v.InflictDamage(palladin_v);
footman_v.InflictDamage(palladin_v);
footman_v.InflictDamage(palladin_v);
footman_v.InflictDamage(cleric_v);
palladin_v.ShowInfo();

cleric_v.ShowInfo();
cleric_v.HillMyself();
cleric_v.ShowInfo();
static void InfoHealthIncreased (int health, string name, int manna, int guard)
{
    Console.WriteLine($"Name: {name} Health: {health} Manna: {manna} Guard: {guard}");
}

static void InfoHealthDecreased(int health, string name, int manna, int guard)
{
    Console.WriteLine($"Name: {name} Health: {health} Manna: {manna} Guard: {guard}");
}

//hello

