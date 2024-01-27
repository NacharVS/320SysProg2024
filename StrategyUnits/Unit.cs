namespace StrategyUnits
{
    internal class Unit : IHealth, IMovingUnit
    {
        public Unit(string? name, bool isDied, double maxHealth)
        {
            _name = name;
            IsDied = isDied;
            _health = maxHealth;
            MaxHealth = maxHealth;

        }
        
        private string? _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsDied { get; set; }
        private double _health;
        public double Health 
        {
            get => _health;
            set
            {
                double pred_health = _health;

                if (value <= 0)
                {
                    _health = 0;
                    IsDied = true;
                }
                else
                {
                    if (value > MaxHealth)
                        _health = MaxHealth;
                    else
                        _health = value;
                }
                if (value <= pred_health)
                {
                    HealthDecreasedEvent.Invoke(_name, _health);
                }
                else if (value > pred_health)
                {
                    HealthIncreasedEvent.Invoke(_name, _health);
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
            Health -= damage;
        }

        public void IncreseHealth(double health)
        {
            Health += health;
        }

        public delegate void HealthChangedDelegate(string? name, double health);
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

    }
}
