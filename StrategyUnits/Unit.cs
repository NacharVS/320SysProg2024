using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Unit : IHealth, IMovingUnit
    {
        private string? _name;
        private int _health { get; set; }
        public  int MaxHealth { get; set; }
        public bool _isDead;

        public event IHealth.HealthChangedDelegate HealthIncreasedEvent;
        public event IHealth.HealthChangedDelegate HealthDecreasedEvent;

        public Unit(string name, int health, int maxHealth, bool isDead)
        {
            _name = name;
            _health = health;
            MaxHealth = maxHealth;
            IsDead = isDead;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool IsDead { get; set; }
        public virtual int Health
        { 
            get => _health; 
            set
            {
                int health1 = _health;
                if (value <= 0)
                {
                    _health = 0;
                    IsDead = true;
                    Console.WriteLine($"{this.Name} мертв.\n");
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _health = MaxHealth;
                        Console.WriteLine($"{this.Name} имеет максимальное HP.\n");
                    }
                    else
                    {
                        _health = value;
                    }
                }
                if (value <= health1)
                {
                    HealthDecreasedEvent.Invoke(_name, _health, _health - value, MaxHealth);
                }
                else if (value > health1)
                {
                    HealthIncreasedEvent.Invoke(_name, _health, _health - value, MaxHealth);
                }
            }
        }
        public void Move()
        {
            Console.WriteLine("Движется");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name} Здоровье: {_health}");
        }
        public virtual void DecreaseHealth(int damage)
        {
            Health -= damage;
        }
        public void IncreaseHealth(int heal)
        {
            Health += heal;
        }
    }
}