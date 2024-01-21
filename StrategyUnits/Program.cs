using StrategyUnits;

void DamageInfo(int health, string name, int? manna, int? damage)
{
    Console.WriteLine($"{name} нанес {damage} урона");
}
void HealthInfo(int health, string name, int? manna, int? damage)
{
    Console.WriteLine($"{name} имеет {health} здоровья");
}
//Footman footman = new Footman();
//footman.HealthChangedFootman += DamageInfo;
//Paladin paladin = new Paladin();
//paladin.AttackPaladin += DamageInfo;
Berserker berserker = new Berserker();
berserker.AttackBerserker += DamageInfo;
Berserker berserker2 = new Berserker();
berserker2.AttackBerserker += DamageInfo;
berserker2.HealthChangedEvent += HealthInfo;
Peasant ps1 = new Peasant();
Cleric cleric1 = new Cleric();


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
berserker2.ShowInfo();
berserker2.Attack(berserker);


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
