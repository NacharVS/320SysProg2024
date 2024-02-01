using StrategyUnits.Units;

namespace StrategyUnits
{
    public class Unit : IHealth
    {
        public delegate void HealthIncreasedDelegate(int previousHealth, int currentHealth, int maxHealth);
        public delegate void HealthDecreasedDelegate(int previousHealth, int currentHealth, int maxHealth);
        public delegate void UnitDeadDelegate();
        public delegate void RageOnDelegate();
        public delegate void RageOffDelegate();
        public delegate void HolyArmorOnDelegate();
        public delegate void HolyArmorOffDelegate();

        private int _currentHealth;
        private int _maxHealth;
        private string? _nameOfClass;
        private bool _isDead = false;
        /*private int _defense;

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }*/
        public string NameOfClass
        {
            get { return _nameOfClass; }
            set { _nameOfClass = value; }
        }

        public virtual int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value <= 0)
                {
                    _currentHealth = 0;
                    IsDead = true;
                    UnitDiedEvent.Invoke();
                }
                else
                    if (value > MaxHealth)
                        _currentHealth = MaxHealth;
                else
                {
                    if (_currentHealth < value)
                    {
                        HealthIncreasedEvent.Invoke(_currentHealth, value, _maxHealth);
                    }
                    else
                    {
                        HealthDecreasedEvent.Invoke(_currentHealth, value, _maxHealth);
                    }
                    _currentHealth = value;
                    if (value <= _maxHealth / 2)
                    {
                        if (GetType() == typeof(Paladin))
                            HolyArmorOnEvent.Invoke();
                        else if (GetType() == typeof(Berserk))
                            RagedEvent.Invoke();
                    }
                    else if (value > _maxHealth / 2)
                    {
                        if (GetType() == typeof(Paladin))
                            HolyArmorOffEvent.Invoke();
                        else if (GetType() == typeof(Berserk))
                            UnragedEvent.Invoke();
                    }
                }
            }
        }
        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }
        public bool IsDead {get; set;}
        public Unit(int currentHealth, string? nameOfClass)
        {
            _currentHealth = currentHealth;
            _nameOfClass = nameOfClass;
            _maxHealth = currentHealth;
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_nameOfClass} Health: {_currentHealth} MaxHealth: {_maxHealth}");
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
        }

        public void GetHeal(int heal)
        {
            CurrentHealth += heal;
        }

        public event HealthIncreasedDelegate HealthIncreasedEvent;
        public event HealthDecreasedDelegate HealthDecreasedEvent;
        public event UnitDeadDelegate UnitDiedEvent;
        public event RageOnDelegate RagedEvent;
        public event RageOffDelegate UnragedEvent;
        public event HolyArmorOnDelegate HolyArmorOnEvent;
        public event HolyArmorOffDelegate HolyArmorOffEvent;
    }
}
