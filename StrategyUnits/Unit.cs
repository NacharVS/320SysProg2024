namespace StrategyUnits
{
    internal class Unit
    {
        private int _currentHealth;
        private int _maxHealth;
        private string? _name;
        private bool _isDead = false;

        public bool IsDead {get; set;}
        public Unit(int currentHealth, string? name)
        {
            _currentHealth = currentHealth;
            _name = name;
            _maxHealth = currentHealth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int CurentHealth 
        { 
            get => _currentHealth;
            set { if (value <= 0)
                    {
                        _currentHealth = 0;
                        IsDead = true;
                    }
                else
                    if (value > MaxHealth)
                        _currentHealth = MaxHealth;
                    else
                        _currentHealth = value;
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
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth} MaxHealth: {_maxHealth}");
        }
    }
}
