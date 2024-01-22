namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(string? name, double health, double difference, double protection, double maxHealth);
        private double _currentHealth;
        private string? _name;
        private double _maxHealth;
        private bool _isDied;
        private double _protection;
        private int _lvlWeapon;

        public int LvlWeapon
        {
            get { return _lvlWeapon; }
            set { _lvlWeapon = value; }
        }
        private int _lvlArmor;

        public int LvlArmor
        {
            get { return _lvlArmor; }
            set { _lvlArmor = value; }
        }

        public virtual double Protection
        {
            get { return _protection; }
            set { _protection = value; }
        }
        public bool IsDied
        {
            get { return _isDied; }
            set { _isDied = value; }
        }

        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public virtual double CurrentHealth
        {
            get => _currentHealth;
            set
            {
                double previousHealth = _currentHealth;

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
                if (value <= previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, _currentHealth, (previousHealth - value), _protection, _maxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, _currentHealth, value - previousHealth, _protection, _maxHealth);
                }
            }
        }

        public Unit(double health, string? name, double protection)
        {
            _currentHealth = health;
            _name = name;
            _maxHealth = health;
            _protection = protection;
            _isDied = false;
            _lvlArmor = 0;
            _lvlWeapon = 0;
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
            Console.WriteLine($" Unit: {_name}\n Health: {_currentHealth}\n LvlWeapon: {_lvlWeapon}\n LvlArmor: {_lvlArmor}");
            Console.WriteLine();
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
