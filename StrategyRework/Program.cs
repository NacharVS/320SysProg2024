using StrategyRework;

CityBarracs barracs = new CityBarracs();
Peasant ps = barracs.CreatePeasant();
Cleric cl = barracs.CreateClerik();
Paladin pl = barracs.CreatePaladin();
Berserker br = barracs.Createberserker();
ps.ShowInfoEvent += ShowInfos;
cl.ShowInfoEvent += ShowInfos;
pl.ShowInfoEvent += ShowInfos;
br.ShowInfoEvent += ShowInfos;
ps.ShowInfo();
cl.ShowInfo();
pl.ShowInfo();
br.ShowInfo();

Battle bat = new Battle();
bat.Battles(pl, br);

void ShowInfos(string name, int health, int? mana, int? damage, int? maxDamage)
{
    if (mana == null && damage == null)
        Console.WriteLine($"Персонаж {name} имеет {health} здоровья.");
    else if (mana == null && damage != null)
        Console.WriteLine($"Персонаж {name} имеет {health} здоровья. Урон составляет от {damage} / {maxDamage}.");
    else if (damage == null && mana != null)
        Console.WriteLine($"Персонаж {name} имеет {health} здоровья и {mana} маны.");
    else
        Console.WriteLine($"Персонаж {name} имеет {health} здоровья и {mana} маны. Урон составляет от {damage} / {maxDamage}.");
}