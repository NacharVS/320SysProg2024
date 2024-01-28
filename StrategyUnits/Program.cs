using StrategyUnits;

static void IncreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    if(newHealth > maxHealth)
        newHealth = maxHealth;
    Console.WriteLine($"{name} восстановил здоровье на {newHealth - oldHealth}. Текущее здоровье {newHealth}/{maxHealth}");
}
static void DecreaseHealth(string name, int oldHealth, int newHealth, int maxHealth)
{
    int damage = oldHealth - newHealth;
    if (newHealth < 0)
        newHealth = 0;
    Console.WriteLine($"{name} получил урон {damage}. Текущее здоровье {newHealth}/{maxHealth}");
}

Barracs barracs = new Barracs();
Altar altar = new Altar(); 
Forge forge = new Forge();

Peasant peasant = new Peasant();
Footman recruit = barracs.CreateRecruit();
Footman footman = barracs.CreateFootman();
Berserker berserker = barracs.CreateBerserker();
Healer healer = altar.CreateHealer();
ZealotKnight zealotKnight = altar.CreateZealotKnight();
Palladin palladin = altar.CreatePalladin();

Unit.HealthIncreasedEvent += IncreaseHealth;
Unit.HealthDecreasedEvent += DecreaseHealth;

recruit.ShowInfo();
footman.ShowInfo();
berserker.ShowInfo();
zealotKnight.ShowInfo();
palladin.ShowInfo();
Console.WriteLine();

forge.UpgradeDamage();
forge.UpgradeDamage();
recruit.ShowInfo();
footman.ShowInfo();
berserker.ShowInfo();
zealotKnight.ShowInfo();
palladin.ShowInfo();
palladin.Attack(peasant);
palladin.Attack(healer);
palladin.Attack(footman);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.Attack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);
palladin.MagicAttack(berserker);

