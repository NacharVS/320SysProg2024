namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public bool Dead { get; set; }
        private bool _dead = false;
        public int _maxHealth;
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
        public int MaxHealth
        { 
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public int Health 
        { 
            get => _health; 
            set
            {
                if(value <= 0)
                {
                    _health = 0;
                    Dead = true;
                    Console.WriteLine("Dude is dead"); 
                }
                else
                    if(value > _maxHealth)
                        _health = _maxHealth;
                    else
                        _health = value;             
            } 
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }
        public void Build()
        {
            Console.WriteLine("Is building something great");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{_maxHealth}");
        }
    }
}
