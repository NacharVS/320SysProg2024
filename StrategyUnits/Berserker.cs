namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int health, string? name, int damage) : base (health, name, damage)
        {

        }

        public void Rage (Unit unit)
        {
            if (Health > (Health * 0.5))
            {
                Damage = (int)(Damage + (Damage * 0.5));
                unit.Health -= Damage;
                Console.WriteLine($"{unit.Name} получил урон {Damage}");
            }
        }
    }
}
