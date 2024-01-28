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
            _currentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsDied { get; set; }
        private double _currentHealth;
        public virtual double CurrentHealth
        {
            get => _currentHealth;
            set
            {
                double previousHealth = _currentHealth;

                if (value <= 0)
                {
                    _currentHealth = 0;
                    IsDied = true;
                    Console.WriteLine($"{Name} умер");
                }
                else
                {
                    if (value > MaxHealth)
                        _currentHealth = MaxHealth;
                    else
                        _currentHealth = value;
                }
                if (value <= previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, _currentHealth, (previousHealth - value), MaxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, _currentHealth, value - previousHealth, MaxHealth);
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

        public virtual void DecreaseHealth(double damage)
        {
            CurrentHealth -= damage;
        }

        public void IncreseHealth(double health)
        {
            CurrentHealth += health;
        }

        public event IHealth.HealthChangedDelegate HealthIncreasedEvent;
        public event IHealth.HealthChangedDelegate HealthDecreasedEvent;

    }
}
