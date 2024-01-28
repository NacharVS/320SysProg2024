using StrategyUnits.Interfase;

namespace StrategyUnits
{
    internal class Unit : IHealth, IInfoAboutSmth
    {
        public int _health { get; set; }

        private string? _name;
        public int MaxHealth { get; set; }
        public bool Alive { get; set; }

        public delegate void RegenerateHealthChange(string? Name, int _health, int _current_health, int MaxHealth);
        public delegate void DecreasedHealthChange(string? Name, int _health, int _current_health, int MaxHealth);
        public event RegenerateHealthChange RegenerateHealthChangeEvent;
        public event DecreasedHealthChange DecreasedHealthChangeEvent;
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
                        RegenerateHealthChangeEvent.Invoke(Name,_health, value, MaxHealth);
                    }
                    else
                    {
                        DecreasedHealthChangeEvent.Invoke(Name, _health, value, MaxHealth);
                    }
                    _health = value;
                }
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

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void RestoreHealth(int health)
        {
            Health += health;
        }
    }
}
