namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthchangedDelegate(string name, int oldHealth, int newHealth, int maxHealth);

        private int _health;
        private string? _name;
        private int _maxHealth;
        private bool _life;

        public Unit(int maxHealth, string? name)
        {
            _maxHealth = maxHealth;
            _health = _maxHealth;
            _name = name;
            _life = true;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Life
        {
            get { return _life; }
            set { _life = value; }
        }

        public int Health 
        { 
            get => _health;
            set 
            {
                if (value > Health)
                {
                    HealthIncreasedEvent.Invoke(Name, Health, value, MaxHealth);
                }
                else
                {
                    HealthDecreasedEvent.Invoke(Name, Health, value, MaxHealth);
                }
                if (value <= 0)
                {
                    _health = 0;
                    _life = false;
                    Console.WriteLine($"Персонаж {Name} умер");
                }
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }

        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        public void Move()
        {
            if (Life)
            {
                Console.WriteLine($"{Name} движется");
            }
            else
            {
                Console.WriteLine($"Персонаж {Name} мертв");
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth}");
        }

        public event HealthchangedDelegate HealthIncreasedEvent;
        public event HealthchangedDelegate HealthDecreasedEvent;
    }
}
