using static StrategyUnits.Unit;

namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health);
        public delegate void HealthIncreasedDelegate(int helth);
        public delegate void HealthDecreasedDelegate(int helth);

        private int _health;
        private int _maxHealth;
        private bool _dead;
        private string? _name;
        public int _pravHealth;

        public int PravHealth
        {
            get { return _pravHealth; }
            set { _pravHealth = value; }
        }
        public bool Dead
        {
            get { return _dead; }
            set { _dead = value; }
        }
        
        public int CurentHealth
        {
            get => _health;
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    _dead = true;
                    
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _health = MaxHealth;
             
                    }
                    else
                    {
                        _health = value;
                        if (_pravHealth < _health)
                        {
                            int v = _health - _pravHealth;
                            HealthDecreasedEvent.Invoke(v);
                        }
                        else
                        {
                            if(_pravHealth > _health)
                            { 
                                int n = _pravHealth - _health;
                                HealthIncreasedEvent.Invoke(n);
                            }
                        }
                    }
                }
                HealthChangedEvent.Invoke(_health);
            }
        }
        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
            _dead = false;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        public void Move()
        {
            Console.WriteLine("Двигается");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name} Максимальное здоровье: {_maxHealth} Здоровье: {_health}");
        }

        public event HealthIncreasedDelegate HealthIncreasedEvent;
        public event HealthDecreasedDelegate HealthDecreasedEvent;
        public event HealthChangedDelegate HealthChangedEvent;
    }
}
