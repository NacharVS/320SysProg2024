using StrategyUnits.Inerfaces;

namespace StrategyUnits.Units
{
    internal class Footman : Unit, IAttack
    {
        public double Damage { get; set; }
        public Footman(string? name, bool isDied, double currentHealth, double maxHealth, double damage) : base(name, isDied, currentHealth, maxHealth)
        {
            Damage = damage;
        }
        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public void DecreaseHealth(double damage)
        {
            CurrentHealth -= damage;
        }

        public void IncreseHealth(double health)
        {
            CurrentHealth += health;
        }
    }
}
