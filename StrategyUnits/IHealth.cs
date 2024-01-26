namespace StrategyUnits
{
    internal interface IHealth
    {
        public int Health { get; set; }

        public void TakeDamage(int damage);
    }
}
