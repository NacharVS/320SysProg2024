using StrategyUnits;
using System.Xml.Linq;

Barracks barrack = new Barracks();
Forge forge = new Forge();
Altar altar = new Altar();
Berserker berserker = barrack.CreateBerserker();
Footman footman = barrack.CreateFootman();
Cleric cleric = altar.CreateCleric();
Paladin paladin = altar.CreatePaladin();
ZealotKnight zealotKnight = altar.CreateZealotKnight();

static void MethodDamage(int damage, int maxHP, int maxProtect, string nameDamaging, string nameDamaged)
{
    Console.WriteLine($"{nameDamaging} аттаковал {nameDamaged}.\n{nameDamaged} получил урон {damage}. Текущий HP {nameDamaged}: {maxHP}. Текущая защита: {maxProtect}.\n");
}

static void MethodHeal(int mana, int maxHP, string nameHealer, string nameHealing)
{
    Console.WriteLine($"{nameHealer} вылечил {nameHealing} до {maxHP}.\nТекущая мана {nameHealer}: {mana}.\n" +
        $"{nameHealing} был вылечен. Текущий HP: {maxHP}.\n");
}
static void MethodLossMana(string name, int maxMana)
{
    Console.WriteLine($"{name} потратил ману. Текущая мана: {maxMana}.\n");
}
static void MethodGetMana(string name, int maxMana)
{
    Console.WriteLine($"{name} восстановил манну. Текущая мана: {maxMana}.\n");
}
berserker.ShowInfo();
footman.ShowInfo();
footman.inflictDamageEvent += MethodDamage;
footman.inflictDamageToProtectEvent += MethodDamage;
berserker.inflictDamageEvent += MethodDamage;
berserker.inflictDamageToProtectEvent += MethodDamage;
cleric.HealEvent += MethodHeal;
zealotKnight.inflictDamageToProtectEvent += MethodDamage;
zealotKnight.inflictDamageEvent += MethodDamage;
zealotKnight.ManaLossEvent += MethodLossMana;
zealotKnight.ManaGetEvent += MethodGetMana;
cleric.ManaLossEvent += MethodLossMana;
cleric.ManaGetEvent += MethodGetMana;
berserker.InflictDamage(footman);
footman.ShowInfo();
cleric.ShowInfo();
berserker.InflictDamage(footman);
footman.ShowInfo();
cleric.Heal(footman);
cleric.ShowInfo();
cleric.Heal(footman);
altar.CreatePaladin();
paladin.ShowInfo();

footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
footman.InflictDamage(zealotKnight);
zealotKnight.InflictDamage(footman);

berserker.ShowInfo();
berserker.ActivateRage();
berserker.InflictDamage(zealotKnight);
berserker.InflictDamage(zealotKnight);
berserker.InflictDamage(zealotKnight);
zealotKnight.ShowInfo();
zealotKnight.Prayer();
zealotKnight.Prayer();
zealotKnight.Prayer();
zealotKnight.Prayer();
zealotKnight.ShowInfo();
altar.RecoverMP(zealotKnight);
altar.RecoverMP(zealotKnight);
altar.RecoverMP(zealotKnight);
zealotKnight.ShowInfo();
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
zealotKnight.InflictDamage(berserker);
