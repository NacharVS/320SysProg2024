namespace StrategyUnits
{
    internal class Unit
    {

        public delegate void HealthChangedDelegate(Unit unit,int health);

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

        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Health
        {
            get => _health;
            set
            {
                if (value < _health)
                    HealthDecreasedEvent.Invoke(this, value);
                if (value > _health)
                    HealthIncreasedEvent.Invoke(this, value);
                if (value <= 0)
                {
                    isAlive = false;
                    _health = 0;
                }
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
                
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
    }
}
