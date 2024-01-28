using StrategyUnits.Inerfaces;

namespace StrategyUnits.Units
{
    internal class Unit : IHealth, IMovingUnit, IGeneralInformation
    {
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
                    HealthDecreasedEvent.Invoke(Name, _currentHealth, (previousHealth - value), MaxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(Name, _currentHealth, value - previousHealth, MaxHealth);
                }
            }
        }
        public double MaxHealth { get; set; }
        public string? Name { get; set; }
        public Unit(string? name, bool isDied, double currentHealth, double maxHealth)
        {
            Name = name;
            IsDied = isDied;
            _currentHealth = currentHealth;
            MaxHealth = maxHealth;
        }
        public void Move()
        {
            Console.WriteLine("Движется");
        }

        public virtual void DecreaseHealth(double damage)
        {
            CurrentHealth -= damage;
        }

        public void IncreseHealth(double health)
        {
            CurrentHealth += health;
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n Здоровье: {CurrentHealth}/{MaxHealth} \n Живой: {IsDied}");
        }

        public event IHealth.HealthChangedDelegate HealthIncreasedEvent;
        public event IHealth.HealthChangedDelegate HealthDecreasedEvent;

    }
}
