namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        private int _protection;        
        public bool isAlive { get; private set; }
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, int protection)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            isAlive = true;
            _protection = protection;
        }

        public int Protection
        {
            get { return _protection; }
            set { _protection = value; }
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
    }
}
