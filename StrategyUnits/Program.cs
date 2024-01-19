using StrategyUnits;

Footman footman1 = new Footman();
Footman footman2 = new Footman();
Peasant peasant1 = new Peasant();
Cleric cleric1 = new Cleric();
Paladin paladin1 = new Paladin();

peasant1.ShowInfo();
footman2.ShowInfo();
paladin1.ShowInfo();
paladin1.GetInfoMana();

footman1.InflictDamageEvent += MethodDamage;
footman2.InflictDamageEvent += MethodDamage;
paladin1.InflictDamageEvent += MethodDamage;

cleric1.HealEvent += MethodHeal;
//footman1.HealthChangedEvent += Method;
//footman2.HealthChangedEvent += Method;
//palladin1.HealthChangedEvent += Method;

footman2.InflictDamage(paladin1);
cleric1.OtherHeal(paladin1);

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

static void MethodDamage(int damage, int maxHP, string nameDamaging, string nameDamaged)
{
    Console.WriteLine($"{nameDamaging} attacked {nameDamaged}.\n{nameDamaged} took damage {damage}. Current HP {nameDamaged}: {maxHP}.");
}

static void MethodHeal(int mana, int maxHP, string nameHealer, string nameHealing)
{
    Console.WriteLine($"{nameHealer} healed the {nameHealing}'s HP to {maxHP}.\nCurrent mana {nameHealer}: {mana}");
}