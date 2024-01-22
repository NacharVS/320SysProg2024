namespace StrategyUnits
{
    internal class Unit
    {
        private string? _name;
        private int _currentHP;
        private bool _deadUnit;
        private int _weaponLvl;
        private int _protection;
        public int MaximumHP { get; private set; }
        public int MaximumProtect { get; private set; }

        public Unit(string? name, int maxHP, int protection)
        {
            _name = name;
            MaximumHP = maxHP;
            _protection = protection;
            _currentHP = MaximumHP;
            _deadUnit = false;
        }

        public int WeaponLvl
        {
            get { return _weaponLvl; }
            set { _weaponLvl = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Protection
        {
            get => _protection;
            set
            {
                if (value < 0)
                {
                    _protection = 0;
                }
                else
                {
                    if (value > MaximumProtect)
                    {
                        _protection = MaximumProtect;
                    }
                    else
                    {
                        _protection = value;
                    }
                }
            }
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
            Console.WriteLine($"Unit: {_name} Health: {_currentHP}/{MaximumHP} Protection {_protection} Unit is dead: {DeadUnit} Weapon Level {_weaponLvl} Armor Level {_armorLvl}");
        }

        public delegate void HPChangeDelegate(int maxHP, string name);

        public event HPChangeDelegate HealthDecreasedEvent;
        public event HPChangeDelegate HealthIncreasedEvent;
        public event HPChangeDelegate HealthChangedEvent;
    }
}