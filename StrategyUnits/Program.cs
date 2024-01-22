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


forge.UpdateLevelWeapon(zealotKnight);

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
footman.InflictDamage(paladin);

paladin.HealthIncreasedEvent += InfoHealthIncreased;
paladin.MannaDecreasedEvent += InfoMannaLess;

Console.WriteLine("Hill");
cleric.HillOthers(paladin);
paladin.HealthIncreasedEvent += InfoHealthIncreased;
paladin.MannaDecreasedEvent += InfoMannaLess;
cleric.HealthIncreasedEvent += InfoHealthIncreased;
cleric.MannaDecreasedEvent += InfoMannaLess;
cleric.HillOthers(paladin);


//berserker.ShowInfo();
//berserker.HealthDecreasedEvent += InfoHealthIncreased;
//berserker.HealthIncreasedEvent += InfoHealthIncreased;
//berserker.InflictDamage(footman);

//berserker.HealthIncreasedEvent += InfoHealthIncreased;
//paladin.ShowInfo();
zealotKnight.ShowInfo();
forge.UpdateLevelWeapon(paladin);
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
altar.ShowInfoAboutAltar();
//paladin = altar.CreatePalladin();
//paladin.ShowInfo();



footman.HealthDecreasedEvent += InfoHealthIncreased;
footman.HealthIncreasedEvent += InfoHealthIncreased;

cleric.HealthDecreasedEvent += InfoHealthIncreased;
cleric.HealthIncreasedEvent += InfoHealthIncreased;


berserker.HealthDecreasedEvent += InfoHealthIncreased;
berserker.HealthIncreasedEvent += InfoHealthIncreased;

//paladin.ShowInfo();
footman.InflictDamage(paladin);
footman.InflictDamage(paladin);


berserker.InflictDamage(footman);
berserker.HealthDecreasedEvent += InfoHealthIncreased;

berserker.Rage(cleric);


cleric.ShowInfo();
paladin.ShowInfo();
cleric.HillOthers(paladin);
cleric.HillOthers(paladin);
cleric.HillOthers(paladin);

paladin.ShowInfo();
berserker.ShowInfo();
footman.ShowInfo();
forge.UpdateLevelArmor(paladin);

berserker.Rage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);
footman.InflictDamage(berserker);


berserker.Rage(cleric);
berserker.ShowInfo();



static void InfoMannaLess (int health, string name, int manna)
{
    Console.WriteLine($"Health: {health} Name: {name} Manna: {manna}");
}

static void InfoHealthIncreased (int health, string name, int manna, int guard)
{
    Console.WriteLine($"Name: {name} Health: {health} Manna: {manna} Guard: {guard}");
}

