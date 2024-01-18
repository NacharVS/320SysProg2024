namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int MaxHealth { get; private set; }
        public bool Alive { get; set; }
        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            Alive = true;
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
                    Alive = false;
                }

                else
                    if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
            } 
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
