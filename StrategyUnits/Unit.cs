namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(string? name, int health, int difference, int defence);
        private int _health;
        private string? _name;
        public int MaxHealth { get; private set; }
        private int _defence; //защита
        public int Defence 
        {
            get { return _defence; }
            set { _defence = value; }
        }
        public Unit(string? name,int health, int defence)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            _diedunit = false;
            _defence = defence;
        }
        private bool _diedunit;

        public bool DiedUnit
        {
            get { return _diedunit; }
            set { _diedunit = value; }
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
                int previousHealth = _health;
                if (value <= 0)
                {
                    _health = 0;
                    _diedunit = true;
                }   
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
                if (value < previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, _health, (previousHealth - value), _defence);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, _health, value - previousHealth, _defence);
                }
            }
           
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name} Жизни: {_health}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
        
    }
}
