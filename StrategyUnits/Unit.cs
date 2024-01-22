namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health);

        private int _health;
        private string? _name;
        public bool isAlive { get; private set; }
        public int MaxHealth { get; private set; }
        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            isAlive = true;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    isAlive = false;
                }
                else
                    if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
                HealthChangedEvent.Invoke(_health);
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
        public event HealthChangedDelegate HealthChangedEvent;
    }
}
