namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(string? name, int health, int difference, int protection, int maxHealth);
        private int _currentHealth;
        private string? _name;
        private int _maxHealth;
        private bool _isDied;
        private int _protection;

        public virtual int Protection
        {
            get { return _protection; }
            set { _protection = value; }
        }
        public bool IsDied
        {
            get { return _isDied; }
            set { _isDied = value; }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public virtual int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                int previousHealth = _currentHealth;

                if (value <= 0)
                {
                    _currentHealth = 0;
                    _isDied = true;
                }
                else
                {
                    if (value > MaxHealth)
                        _currentHealth = MaxHealth;
                    else
                        _currentHealth = value;
                }
                if (value < previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, _currentHealth, (previousHealth - value), _protection, _maxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, _currentHealth, value - previousHealth, _protection, _maxHealth);
                }

            }
        }

        public Unit(int health, string? name, int protection)
        {
            _currentHealth = health;
            _name = name;
            _maxHealth = health;
            _protection = protection;
            _isDied = false;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
