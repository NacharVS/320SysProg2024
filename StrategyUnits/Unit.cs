namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int MaxHealth { get; private set; }
        public bool Alive { get; set; }

        private int _defense;

        public delegate void RegenerateHealthChange(int _health,int _current_health, int MaxHealth);
        public delegate void DecreasedHealthChange(int _health,int _current_health, int MaxHealth);
        public event RegenerateHealthChange RegenerateHealthChangeEvent;
        public event DecreasedHealthChange DecreasedHealthChangeEvent;
        public Unit(int health, string? name, int defense)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            Alive = true;
            _defense = defense;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual int Health 
        { 
            get => _health; 
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Alive = false;
                }
                else
                    if (value > MaxHealth)
                    _health = MaxHealth;
                else
                {
                    if (_health < value)
                    {
                        RegenerateHealthChangeEvent.Invoke(_health, value, MaxHealth);
                    }
                    else
                    {
                        DecreasedHealthChangeEvent.Invoke(_health, value, MaxHealth);
                    }
                    _health = value;                    
                }  
            } 
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public void Move()
        {
            Console.WriteLine("Идёт");
        }

        public virtual void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {_name} Здоровье: {_health}");
            else
                Console.WriteLine($"{Name} мертв");
        }
    }
}
