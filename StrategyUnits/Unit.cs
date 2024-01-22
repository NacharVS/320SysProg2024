namespace StrategyUnits
{
    internal class Unit
    {
        
        private double _health;
        private string? _name;
        private double _maxHealth;
        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        private double _defence; //защита
        public virtual double Defence 
        {
            get { return _defence; }
            set { _defence = value; }
        }

        private int _lvlArmor;
        public int LvlArmor
        {
            get { return _lvlArmor; }
            set { _lvlArmor = value; }
        }
        
        public Unit(string? name, double health, double defence)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
            _diedunit = false;
            _defence = defence;
            _lvlArmor = 0;
        }
        private bool _diedunit;

        public bool DiedUnit
        {
            get { return _diedunit; }
            set { _diedunit = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual double Health 
        { 
            get => _health;
            set
            {
                double previousHealth = _health;
                if (value <= 0)
                {
                    _health = 0;
                    _diedunit = true;
                }   
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
                if (value < previousHealth)
                {
                    HealthDecreasedEvent.Invoke(_name, _health, (previousHealth - value));
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(_name, _health, value - previousHealth);
                }
            }
           
        }

        public void Move()
        {
            Console.WriteLine("Движется");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {_name} Жизни: {_health} Уровень защиты: {_lvlArmor}");
        }
        public delegate void HealthChangedDelegate(string? name, double health, double difference);
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
        
    }
}
