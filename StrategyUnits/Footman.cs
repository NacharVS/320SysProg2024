namespace StrategyUnits
{
    internal class Footman : IHealth, IAttack
    {
        public double Health { get; set; }
        public bool IsDied { get; set; }
        public double MaxHealth { get; set; }
        public double Damage { get; set; }

        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public void DecreaseHealth(double damage)
        {
            Health -= damage;
        }

        public void IncreseHealth(double health)
        {
            Health += health;
        }
    }
}
