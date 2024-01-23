using StrategyUnits;

void DamageInfo(int health, string name, int? manna, int? damage, int? health1)
{
    if (health > 0)
        Console.WriteLine($"У {name} {health} здоровья и он нанес {damage} урона оставив у врага {health1} здоровья");
}
void HealthInfo(int health, string name, int? manna, int? damage, int? health1)
{
    if (health > 0)
        Console.WriteLine($"{name} имеет {health} здоровья");
}
void HealInfo(int health, string name, int? manna, int? damage, int? health1)
{
    if (health > 0)
        Console.WriteLine($"Клирик вылечил {name}. {name} имеет {health} здоровья. У него осталось {manna} маны");
}

//footman.HealthChangedEvent += HealthInfo;
//Paladin paladin = new Paladin();
//paladin.AttackPaladin += DamageInfo;
Barracs barracs1 = new Barracs();
Berserker berserker = barracs1.CreateBerserker();
Berserker berserker2 = barracs1.CreateBerserker();
Cleric cleric = (Cleric)barracs1.CreateCleric();
Paladin paladin = new Paladin();
paladin.AttackPaladin += DamageInfo;
berserker.AttackBerserker += DamageInfo;
berserker2.AttackBerserker += DamageInfo;
berserker2.HealthChangedEvent += HealthInfo;
cleric.ClericHeal += HealInfo;




//проверка для лечения крестьянина клириком
Console.WriteLine("Peasant");

Console.WriteLine();
Console.WriteLine("After damage");
berserker.Attack(berserker2);
berserker.Attack(berserker2);
berserker.Attack(berserker2);
berserker.Attack(berserker2);
berserker.Attack(berserker2);
berserker.Attack(berserker2);
paladin.Attack(berserker2);
berserker2.Attack(cleric);
cleric.Heal(cleric);


//Console.WriteLine();
//Console.WriteLine("After heal");
//cleric1.Heal(ps1);
//ps1.ShowInfo();
//cleric1.ShowInfo();
//Console.WriteLine();

////проверка для лечения клирика самим собой и регенерации его маны
//Console.WriteLine();
//Console.WriteLine("Cleric");
//cleric1.ShowInfo();

//Console.WriteLine();
//Console.WriteLine("After regen Manna");
////cleric1.MannaRegen(cleric1);
//cleric1.ShowInfo();

//Console.WriteLine();
//Console.WriteLine("After heal");
//cleric1.Heal(cleric1);
//cleric1.ShowInfo();

//Console.WriteLine();
//Console.WriteLine("After x8 damage");
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//footman.InflictDamage(cleric1);
//cleric1.ShowInfo();

//Console.WriteLine();
//Console.WriteLine("After last damage");
//footman.InflictDamage(cleric1);
//cleric1.ShowInfo();
