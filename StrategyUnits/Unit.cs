namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private int _maxHealth;
        private bool _dead = false;
        private string? _name;
        public bool Dead { get; set; }
        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int CurentHealth 
        { 
            get => _health;
            set { if (value <= 0)
                    {
                        _health = 0;
                        Dead = true;
                    }
                else
                    if (value > MaxHealth)
                        _health = MaxHealth;
                    else
                        _health = value;
            } 
        }

        public int Health 
        { 
            get => _health; 
            set
            {
                if(value < 0)
                    _health = 0;
                else
                    if(value > _maxHealth)
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
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} MaxHealth: {_maxHealth} Health: {_health}");
        }
    }
}
