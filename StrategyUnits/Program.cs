using StrategyUnits;
using System.Xml.Linq;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Cliric cl1 = new Cliric();
//Peasant ps2 = new Peasant();
//Cliric cl2 = new Cliric();
Paladin pl1 = new Paladin();
Altar altar = new Altar();

ps1.HealthChangeEvent += ShowInfo;
footman.HealthChangeEvent += ShowInfo;
cl1.ShowInfoCliric += ShowInfoCliric;
footman.AttackUnit += damageInfo;
cl1.HealUnit += healInfo;
pl1.MagicFireBollAttack += damageInfo;
//cl1.StickCliricAttack += damageInfo;
altar.altarHealMP += AltarHealMP;
cl1.AttackUnit += damageInfo;
//Задание просмотр работы убийства
cl1.ShowInfo();
ps1.ShowInfo();
cl1.Attack(pl1);
footman.ShowInfo();
footman.Attack(ps1);
footman.Attack(ps1);
pl1.Attack(ps1);
footman.Attack(cl1);
cl1.HealHealthunit(ps1);
cl1.HealHealthunit(cl1);
cl1.ShowInfo();
altar.RestoreMP(cl1);
//footman.Attack(ps1);
//footman.Attack(ps1);

//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//ps1.ShowInfo();
//Console.WriteLine();
////Задание с лечением и маной

//ps2.ShowInfo();
//footman.InflictDamage(ps2);
//footman.InflictDamage(cl1);
//ps2.ShowInfo();
//cl1.ShowInfo();
//cl1.InflictHeal(ps2);
//cl1.InflictHeal(cl1);
//ps2.ShowInfo();
//cl1.ShowInfo();
//Console.WriteLine("Клирик который лечил: ");
//cl1.ShowInfo();

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
