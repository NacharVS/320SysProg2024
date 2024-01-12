namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        private int _maxHealth;

        public Unit(int maxHealth, string? name)
        {
            _maxHealth = maxHealth;
            _health = _maxHealth;
            _name = name;
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
                if(value < 0)
                    _health = 0;
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
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
