namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(string name, int health, int newHealth);
        
        private int _health;
        private string? _name;

        public int MaxHealth { get; private set; }
        public Unit(string? name, int health)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        { 
            get => _health;
            set {
                if (value > Health)
                {
                    HealthIncreasedEvent.Invoke(Name, Health, value);
                }
                else
                {
                    HealthDecreasedEvent.Invoke(Name, Health, value);
                }
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > MaxHealth)
                        _health = MaxHealth;
                    else
                        _health = value;
                }
                if (this is Berserker bersk)
                {
                    if (Health < MaxHealth / 2 && !bersk._rage)
                    {
                        bersk._rage = true;
                        Console.WriteLine($"{Name} активировал ярость. Урон увеличился - {bersk.MinDamage}-{bersk.MaxDamage}");
                    }
                    if (Health > MaxHealth / 2 && bersk._rage)
                    {
                        bersk._rage = false;
                        Console.WriteLine($"{Name} деактивировал ярость. Урон снова обычный - {bersk.MinDamage}-{bersk.MaxDamage}");
                    }
                }
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

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}