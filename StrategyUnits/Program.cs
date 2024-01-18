using StrategyUnits;

Footman footman = new Footman();
Paladin paladin = new Paladin();
Altar altar = new Altar();
Cleric cleric = new Cleric();

footman.DecreasedHealthChangeEvent += Footman_DecreasedHealthChangeEvent;
footman.RegenerateHealthChangeEvent += Footman_RegenerateHealthChangeEvent;
paladin.DecreasedHealthChangeEvent += Paladin_DecreasedHealthChangeEvent;
paladin.RegenerateHealthChangeEvent += Paladin_RegenerateHealthChangeEvent;
cleric.DecreasedHealthChangeEvent += Cleric_DecreasedHealthChangeEvent;
cleric.RegenerateHealthChangeEvent += Cleric_RegenerateHealthChangeEvent;

paladin.FireAttack(footman);
paladin.FireAttack(cleric);
cleric.CureSomebody(footman);

altar.RestoreMana(cleric);
cleric.ShowInfo();
void Cleric_RegenerateHealthChangeEvent(int _health,int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Cleric_DecreasedHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье упало на {_health-_current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Paladin_RegenerateHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Paladin_DecreasedHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Footman_RegenerateHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Footman_DecreasedHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}