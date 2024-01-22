namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int health, string? name, int armor, int damage) : base (health, name, armor, damage)
        {

        }

        public void Rage(Unit unit) //Ярость
        {
            if (IsDead == true)
                Console.WriteLine($"{Name} мёртв.");
            else
            {
                if (Health >= (MaxHealth / 2)) //(120 > 60)
                {
                    if (unit.IsDead == true || unit.Health <= 0)
                        Console.WriteLine($"{unit.Name} мёртв. Атака невозможна.");
                    else
                    {
                        unit.Health -= (int)(Damage + (Damage * 0.5)); ;
                        Console.WriteLine($"{unit.Name} получил урон {Damage + (Damage * 0.5)}");
                    }
                }
                else if (Health < (MaxHealth / 2))
                    Console.WriteLine("Нельзя использовать Ярость");


            }
        }
    }
}
