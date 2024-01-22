﻿using StrategyUnits;
using System.Xml.Linq;

//Footman footman1 = new Footman();
//Footman footman2 = new Footman();
//Peasant peasant1 = new Peasant();
//Cleric cleric1 = new Cleric();
//Paladin paladin1 = new Paladin();

//peasant1.ShowInfo();
//footman2.ShowInfo();
//paladin1.ShowInfo();
//paladin1.GetInfoMana();

//footman1.InflictDamageEvent += MethodDamage;
//footman2.InflictDamageEvent += MethodDamage;
//paladin1.InflictDamageEvent += MethodDamage;

//footman1.HealthChangedEvent += Method;
//footman2.HealthChangedEvent += Method;
//palladin1.HealthChangedEvent += Method;

//footman2.InflictDamage(paladin1);
//cleric1.OtherHeal(paladin1);

//footman1.InflictDamage(ps1);
//footman1.InflictDamage(footman2);
//ps1.ShowInfo();
//footman2.ShowInfo();
//cl1.ShowInfo();
//cl1.SelfHeal(cl1);
//cl1.ShowInfo();
//cl1.OtherHeal(ps1);
//ps1.ShowInfo();
//cl1.ShowInfo();
//cl1.ShowInfoCleric();

//footman2.ShowInfo();
//footman1.InflictDamage(cl1);
//cl1.ShowInfo();
//cl1.SelfHeal(ps1);
//cl1.ShowInfo();
//cl1.ShowInfoCleric();


//footman2.ShowInfo();
//footman1.InflictDamage(cl1);
//cl1.ShowInfo();
//cl1.SelfHeal(ps1);
//cl1.ShowInfo();
//cl1.ShowInfoCleric();



//Barracks barracks = new Barracks();
//Footman footman = barracks.CreateRecruit();
//footman.ShowInfo();

//Footman footman1 = barracks.CreateFootman();
//footman1.ShowInfo();


//static void Method(int number)
//{
//    Console.WriteLine($"Health has changed. Current HP {number}");
//}
Barracks barrack = new Barracks();
Forge forge = new Forge();
Altar altar = new Altar();
Berserker berserker = barrack.CreateBerserker();
Footman footman = barrack.CreateFootman();
Cleric cleric = altar.CreateCleric();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();
//zealotKnight.ShowInfo();
//forge.WeaponUpgrade(paladin);
//forge.WeaponUpgrade(zealotKnight);
//forge.WeaponUpgrade(zealotKnight);
//forge.ArmorUpgrade(zealotKnight);
//forge.ArmorUpgrade(paladin);
//forge.ArmorUpgrade(paladin);
//forge.ArmorUpgrade(paladin);
//zealotKnight.ShowInfo();
//paladin.ShowInfo();
//footman.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
//footman.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;

//cleric.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
//cleric.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
//cleric.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
//cleric.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

//paladin.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
//paladin.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
//paladin.EnergyIncreasedEvent += ShowInformationAfterEnergyIsRestored;
//paladin.EnergyDecreasedEvent += ShowInformationAfterLossOfEnergy;

//berserker.HealthDecreasedEvent += ShowInformationAfterLossOfHealth;
//berserker.HealthIncreasedEvent += ShowInformationAfterHealthIsRestored;
//footman.InflictDamage(berserker);
//footman.InflictDamage(berserker);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//footman.InflictDamage(paladin);
//berserker.InflictDamage(footman);
//footman.InflictDamage(berserker);
//berserker.InflictDamage(footman);
//cleric.Heal(paladin);
//footman.InflictDamage(berserker);
//footman.InflictDamage(cleric);
//cleric.Heal(cleric);
//altar.RecoverMP(cleric);
//cleric.Heal(cleric);
//cleric.InflictDamage(footman);
//cleric.Heal(footman);
static void MethodDamage(int damage, int maxHP, int maxProtect, string nameDamaging, string nameDamaged)
{
    Console.WriteLine($"{nameDamaging} attacked {nameDamaged}.\n{nameDamaged} took damage {damage}. Current HP {nameDamaged}: {maxHP}. Current Protection {maxProtect}.");
}

static void MethodHeal(int mana, int maxHP, string nameHealer, string nameHealing)
{
    Console.WriteLine($"{nameHealer} healed the {nameHealing}'s HP to {maxHP}.\nCurrent mana {nameHealer}: {mana}\n" +
        $"{nameHealing} treated. Current HP: {maxHP}");
}
void MethodLossMana(string name, int maxMana)
{
    Console.WriteLine($"{name} энергия уменьшена на {difference}, текущая энергия: {energy}/{maxEnergy}");
}
void MethodGetMana(string name, int maxMana)
{
    Console.WriteLine($"{name} энергия увеличена на {difference}, текущая энергия: {energy}/{maxEnergy}");
}
berserker.ShowInfo();
footman.ShowInfo();
berserker.inflictDamageEvent += MethodDamage;
berserker.inflictDamageToProtectEvent += MethodDamage;
cleric.HealEvent += MethodHeal;
zealotKnight.ManaLossEvent += MethodLossMana;
berserker.InflictDamage(footman);
footman.ShowInfo();
cleric.ShowInfo();
berserker.InflictDamage(footman);
footman.ShowInfo();
cleric.Heal(footman);
cleric.ShowInfo();

