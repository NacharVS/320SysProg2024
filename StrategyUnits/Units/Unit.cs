using StrategyUnits.Inerfaces;

namespace StrategyUnits.Units
{
    internal class Unit : IHealth, IMovingUnit
    {

        private string? _name;

        public Unit(string? name, bool isDied, double currentHealth, double maxHealth)
        {
            _name = name;
            IsDied = isDied;
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsDied { get; set; }
        public double CurrentHealth
        {
            get => CurrentHealth;
            set
            {
                double previousHealth = CurrentHealth;

                if (value <= 0)
                {
                    CurrentHealth = 0;
                    IsDied = true;
                }
                else
                {
                    if (value > MaxHealth)
                        CurrentHealth = MaxHealth;
                    else
                        CurrentHealth = value;
                }
                if (value <= previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, CurrentHealth, (previousHealth - value), MaxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, CurrentHealth, value - previousHealth, MaxHealth);
                }
            }
        }
        public double MaxHealth { get; set; }

        public void Move()
        {
            Console.WriteLine("Движется");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name}");
        }

        public void DecreaseHealth(double damage)
        {
            CurrentHealth -= damage;
        }

        public void IncreseHealth(double health)
        {
            CurrentHealth += health;
        }

        public delegate void HealthChangedDelegate(string? name, double health, double difference, double maxHealth);
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

    }
}
