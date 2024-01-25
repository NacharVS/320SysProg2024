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
//peasant.HealthIncreasedEvent += IncreaseHealth;
//peasant.HealthDecreasedEvent += DecreaseHealth;
//recruit.HealthIncreasedEvent += IncreaseHealth;
//recruit.HealthDecreasedEvent += DecreaseHealth;
//footman.HealthIncreasedEvent += IncreaseHealth;
//footman.HealthDecreasedEvent += DecreaseHealth;
//berserker.HealthIncreasedEvent += IncreaseHealth;
//berserker.HealthDecreasedEvent += DecreaseHealth;
//healer.HealthIncreasedEvent += IncreaseHealth;
//healer.HealthDecreasedEvent += DecreaseHealth;
//zealotKnight.HealthIncreasedEvent += IncreaseHealth;
//zealotKnight.HealthDecreasedEvent += DecreaseHealth;
//palladin.HealthIncreasedEvent += IncreaseHealth;
//palladin.HealthDecreasedEvent += DecreaseHealth;

peasant.ShowInfo();
recruit.ShowInfo();
footman.ShowInfo();
berserker.ShowInfo();
healer.ShowInfo();
zealotKnight.ShowInfo();
palladin.ShowInfo();
Console.WriteLine();

recruit.Attack(peasant);
recruit.Attack(footman);
palladin.Attack(berserker);
palladin.MagicAttack(berserker);
healer.Heal(peasant);
zealotKnight.Attack(palladin);
palladin.Prayer();
palladin.HolyArmor();
forge.UpgradeDamage(footman);
forge.UpgradeDamage(footman);
forge.UpgradeDamage(footman);
footman.Attack(peasant);
footman.Attack(peasant);
footman.Attack(peasant);
footman.Attack(peasant);
footman.Attack(peasant);
footman.Attack(peasant);
footman.Attack(peasant);
healer.Heal(peasant);
forge.UpgradeShield(palladin);
forge.UpgradeShield(healer);
forge.UpgradeShield(palladin);
forge.UpgradeShield(palladin);
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(berserker);
footman.Attack(berserker);
berserker.Attack(footman);
altar.RestoreMana(healer);
healer.Attack(palladin);
healer.Attack(palladin);
healer.Attack(palladin);