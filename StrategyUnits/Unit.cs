namespace StrategyUnits
{
    internal class Unit
    {
        private int _currentHealth;
        private string? _name;
        private int _maxHealth;
        private bool _isDied;

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
        public int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value < 0)
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
            }
        }

        public Unit(int health, string? name)
        {
            _currentHealth = health;
            _name = name;
            _maxHealth = health;
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

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}");
        }
    }
}
