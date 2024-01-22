namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int health, string? name, int armor, int damage) : base (health, name, armor, damage)
        {

        }

        public void Rage (Unit unit) //Ярость
        {
            if (IsDead == true)
                Console.WriteLine($"{Name} мёртв.");
            else if(Health > (Health * 0.5) )
            {
                if (unit.IsDead == true)
                    Console.WriteLine($"{unit.Name} мёртв. Атака невозможна.");
                else
                {
                    Damage = (int)(Damage + (Damage * 0.5));
                    unit.Health -= Damage;
                    Console.WriteLine($"{unit.Name} получил урон {Damage}");
                }

            }
        }
    }
}
