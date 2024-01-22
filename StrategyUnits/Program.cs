using StrategyUnits;
using System.Xml.Linq;

Peasant ps1 = new Peasant();

HogwartsBarracs hgBara = new HogwartsBarracs();
MagicUnit cl1 = hgBara.CreateCliric();
Paladin unit2 = hgBara.CreatePaladin();

Altar altar = new Altar();
Battle battle = new Battle();
//ps1.HealthChangeEvent += ShowInfo;
//footman.HealthChangeEvent += ShowInfo;
//cl1.ShowInfoCliric += ShowInfoCliric;
//footman.AttackUnit += damageInfo;
//cl1.HealUnit += healInfo;
unit2.MagicFireBollAttack += damageInfo;
//altar.altarHealMP += AltarHealMP;
//cl1.AttackUnit += damageInfo;
unit2.ShowInfoCliric += ShowInfoCliric; 
//cl1.ShowInfo();
//ps1.ShowInfo();
//cl1.Attack(pl1);
//footman.ShowInfo();
//footman.Attack(ps1);
//footman.Attack(ps1);
//pl1.Attack(ps1);
//footman.Attack(cl1);
//cl1.HealHealthunit(ps1);
//cl1.HealHealthunit(cl1);
//cl1.ShowInfo();
//altar.RestoreMP(cl1);


Barracs bar = new Barracs();
MilitaryUnit unit = bar.CreateBerserker();
unit.HealthChangeEvent += ShowInfo;
unit.InfoSolderChangeEvent += InfoBattleUnit;
unit.AttackUnit += damageInfo;
unit2.InfoSolderChangeEvent += InfoBattleUnit;



//бой между 2 персонжами
unit.ShowInfo();
unit2.ShowInfo();
battle.Battles(unit, unit2);

//это улучшение урона до 2 уровня, броня тоже также работает
Forge forge = new Forge();
forge.AppGradeOneAttack(cl1);
forge.AppGradeOneAttack(cl1);
forge.AppGradeOneAttack(cl1);

void damageInfo(int health, string name, int action, int? mana)
{
    if (health == 0)
    {
        Console.WriteLine($"{name} погиб получив дамаг {action} ед и оставшийся с {health} HP");
    }
    else
    {
        if (mana != null)
        {
            Console.WriteLine($"{name} получил {action} поинтов дамага огненым шаром ценой {mana} MP и у него осталось {health} HP");
        }
        else
            Console.WriteLine($"{name} получил {action} поинтов дамага и у него осталось {health} HP");
    }
}
void InfoBattleUnit(int health, string name, int action, int? mana)
{
    Console.WriteLine($"У {name} есть HP = {health} и урон равный {mana}");
}

void healInfo(int health, string name, int action, int? mana)
{
    Console.WriteLine($"{name} (a) изличили за {action} HP и у него стало {health} HP.");
}
void ShowInfo(int health, string name, int action, int? mana)
{
    if (action == 1)
    {
        Console.WriteLine($"{name} Пчел мёртв");
    }
    else
        Console.WriteLine($"Unit: {name} Health: {health} HP");
}

void ShowInfoCliric(int health, string name, int action, int? mana)
{
    if (action == 1)
    {
        Console.WriteLine($"{name} Пчел мёртв");
    }
    else
        Console.WriteLine($"Unit: {name} Health: {health} HP и {mana} MP");
}
void AltarHealMP(int mana,string name, int energy, int mpHeal)
{
    Console.WriteLine($"Алтарь востановил {mpHeal} MP {name} затратив {energy} EN, мана {name}: {mana} MP");
}
