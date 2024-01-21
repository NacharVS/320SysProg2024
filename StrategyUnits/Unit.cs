using System.Diagnostics;
using static StrategyUnits.Unit;

namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health);
        public delegate void HealthIncreasedDelegate(int helth);
        public delegate void HealthDecreasedDelegate(int helth);
        public delegate void FootmanRageDelegate(int damage);

        public int _health;
        public int _maxHealth;
        private bool _dead;
        private string? _name;
        public int _pravHealth;
        public int _weapon;
        public int _armor;
        
        public bool Rage { get; set; }
        
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }


        public int Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
            _dead = false;
            _weapon = 0;
            _armor = 0;
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
        public virtual int CurentHealth
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
                        double procent = Math.Round((double)CurentHealth / (double)_maxHealth, 4);
                        
                        if (_pravHealth < _health)
                        {
                            int v = _health - _pravHealth;
                            HealthDecreasedEvent.Invoke(v);
                        }
                        else
                        {
                            int n = _pravHealth - _health;
                            HealthIncreasedEvent.Invoke(n);
                        }

                        if ((procent <= 0.5) && (Name == "Recruit"))
                        {
                            FootmanRageEvent.Invoke(_health);
                            Rage = true;
                        }
                    }
                }
                HealthChangedEvent.Invoke(_health);
            }
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
        public event FootmanRageDelegate FootmanRageEvent;
    }
}
