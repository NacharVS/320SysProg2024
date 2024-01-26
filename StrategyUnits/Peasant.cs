using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Peasant : IHealth
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Peasant()
        {
            Name = "Peasant";
            Health = 30;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
