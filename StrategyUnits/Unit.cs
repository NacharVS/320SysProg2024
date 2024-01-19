namespace StrategyUnits
{
    internal class Unit
    {
        private string? _name;
        private int _currentHP;
        private bool _deadUnit;
        public int MaximumHP { get; private set; }

        public Unit(int maxHP, string? name)
        {
            _name = name;
            MaximumHP = maxHP;
            _currentHP = MaximumHP;
            _deadUnit = false;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int CurrentHP
        { 
            get => _currentHP; 
            set
            {
                if (value < 0)
                {
                    _currentHP = 0;
                    _deadUnit = true;
                    Console.WriteLine($"Unit {Name} is dead.");
                }
                else
                {
                    if (value > MaximumHP)
                    {
                        _currentHP = MaximumHP;
                        Console.WriteLine("Unit has MaxHP.");
                    }
                    else
                    {
                        _currentHP = value;
                    }
                }
            }
        }
        public bool DeadUnit
        {
            get { return _deadUnit; }
            set { _deadUnit = value; }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHP}/{MaximumHP} Unit is dead: {DeadUnit}");
        }

        public delegate void HPChangeDelegate(int maxHP, string name);

        public event HPChangeDelegate HealthDecreasedEvent;
        public event HPChangeDelegate HealthIncreasedEvent;
        public event HPChangeDelegate HealthChangedEvent;
    }
}