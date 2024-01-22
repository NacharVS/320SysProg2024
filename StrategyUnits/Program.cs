using StrategyUnits;
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
cleric.DecreasedHealthChangeEvent += Cleric_DecreasedHealthChangeEvent;
cleric.RegenerateHealthChangeEvent += Cleric_RegenerateHealthChangeEvent;
berserker.DecreasedHealthChangeEvent += Berserker_DecreasedHealthChangeEvent;
berserker.RegenerateHealthChangeEvent += Berserker_RegenerateHealthChangeEvent;

paladin.FireAttack(berserker);
paladin.FireAttack(berserker);
paladin.FireAttack(berserker);
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

berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker); 
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);
berserker2.InflictDamage(berserker);

reforge.UpdateWeapon(berserker2);
reforge.UpdateArmor(berserker2);


void Berserker_RegenerateHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье восстановилось на {_current_health - _health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}

void Berserker_DecreasedHealthChangeEvent(int _health, int _current_health, int MaxHealth)
{
    Console.WriteLine($"Здоровье упало на {_health - _current_health}. Текущее здоровье: {_current_health}/{MaxHealth}");
}
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
