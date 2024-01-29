using StrategyUnits;
using StrategyUnits.Interfase;
using static System.Net.Mime.MediaTypeNames;

Altar altar = new Altar();
Barracks barracks = new Barracks();
Berserker berserker = barracks.CreateBerserker();
Paladin paladin = altar.CreatePaladin();
Cleric cleric = altar.CreateCleric();
Berserker berserker2 = barracks.CreateBerserker();
Reforge reforge = new Reforge();

paladin.DecreasedHealthChangeEvent += Paladin_DecreasedHealthChangeEvent;
paladin.RegenerateHealthChangeEvent += Paladin_RegenerateHealthChangeEvent;
paladin.RegenerateManaEvent += Paladin_RegenerateManaEvent;
paladin.DecreasedManaEvent += Paladin_DecreasedManaEvent;
paladin.InflictDamageSmbdEvent += Paladin_InflictDamageSmbdEvent;
cleric.DecreasedHealthChangeEvent += Cleric_DecreasedHealthChangeEvent;
cleric.RegenerateHealthChangeEvent += Cleric_RegenerateHealthChangeEvent;
cleric.RegenerateManaEvent += Cleric_RegenerateManaEvent;
cleric.DecreasedManaEvent += Cleric_DecreasedManaEvent;
cleric.InflictDamageSmbdEvent += Cleric_InflictDamageSmbdEvent;
berserker.DecreasedHealthChangeEvent += Berserker_DecreasedHealthChangeEvent;
berserker.RegenerateHealthChangeEvent += Berserker_RegenerateHealthChangeEvent;
berserker.InflictDamageSmbdEvent += Berserker_InflictDamageSmbdEvent;

berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);
berserker.InflictDamage(paladin);

cleric.CureSomebody(paladin);
cleric.CureSomebody(paladin);
cleric.CureSomebody(paladin);
cleric.CureSomebody(paladin);
cleric.CureSomebody(paladin);
cleric.CureSomebody(paladin);

cleric.ShowInfo();
reforge.UpdateWeapon();
reforge.UpdateWeapon();
reforge.UpdateArmor();
cleric.ShowInfo();


void Berserker_RegenerateHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье {Name} восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Berserker_DecreasedHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье {Name} упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}
void Cleric_RegenerateHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье {Name} восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Cleric_DecreasedHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье {Name} упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Paladin_RegenerateHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье  {Name}  восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Paladin_DecreasedHealthChangeEvent(string? Name, int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье  {Name}  упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Cleric_DecreasedManaEvent(string? Name, int _current_mana, int _mana, int _max_mana)
{
    Console.WriteLine($"Мана {Name} упала на {_current_mana - _mana}. Текущая мана: {_mana}/{_max_mana}");
}

void Cleric_RegenerateManaEvent(string? Name, int _current_mana, int _mana, int _max_mana)
{
    Console.WriteLine($"Мана {Name} восстановилось на {_mana - _current_mana}. Текущая мана: {_mana}/{_max_mana}");
}

void Paladin_DecreasedManaEvent(string? Name, int _current_mana, int _mana, int _max_mana)
{
    Console.WriteLine($"Мана {Name} упала на {_current_mana - _mana}. Текущая мана: {_mana}/{_max_mana}");
}

void Paladin_RegenerateManaEvent(string? Name, int _current_mana, int _mana, int _max_mana)
{
    Console.WriteLine($"Мана {Name} восстановилось на {_mana - _current_mana}. Текущая мана: {_mana}/{_max_mana}");
}
void Berserker_InflictDamageSmbdEvent(string? Name, int damage)
{
    Console.WriteLine($"{Name} начал атаковать и нанес удар с {damage} уроном");
}
void Cleric_InflictDamageSmbdEvent(string? Name, int damage)
{
    Console.WriteLine($"{Name} начал атаковать и нанес удар с {damage} уроном");
}
void Paladin_InflictDamageSmbdEvent(string? Name, int damage)
{
    Console.WriteLine($"{Name} начал атаковать и нанес удар с {damage} уроном");
}
