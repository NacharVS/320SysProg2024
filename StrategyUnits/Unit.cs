namespace StrategyUnits
{
    internal class Unit
    {
        private int _currentHealth;
        private int _maxHealth;
        private string? _nameOfClass;
        private bool _isDead = false;
        private int _defense;
        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public string NameOfClass
        {
            get { return _nameOfClass; }
            set { _nameOfClass = value; }
        }

        public int CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value <= 0)
                {
                    _currentHealth = 0;
                    IsDead = true;
                }
                else
                    if (value > MaxHealth)
                    _currentHealth = MaxHealth;
                else
                    _currentHealth = value;
            }
        }
        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }
        public bool IsDead {get; set;}
        public Unit(int currentHealth, string? nameOfClass, int defense)
        {
            _currentHealth = currentHealth;
            _nameOfClass = nameOfClass;
            _maxHealth = currentHealth;
            _defense = defense;
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_nameOfClass} Health: {_currentHealth} MaxHealth: {_maxHealth} Defense: {_defense}");
        }
    }
}
