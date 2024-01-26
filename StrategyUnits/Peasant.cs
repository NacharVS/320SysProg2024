namespace StrategyUnits
{
    internal class Peasant : IHealth
    {
        private int _health;

        public int Health {
            get => _health;
            set
            {
                if (value <= 0)
                {
                     IsAlive = false;
                    _health = 0;
                }
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;

            }
        }
        public bool IsAlive { get ; set; }
        public int MaxHealth { get; set; }
        public Peasant()
        {
            IsAlive = true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Peasant HP:{Health}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}