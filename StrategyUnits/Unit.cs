namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int _prevHealth;
        public bool Dead { get; set; }
        private bool _dead = false;
        public int _maxHealth;
        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
        }
        public int PrevHealth
        {
            get => _prevHealth;
            set
            {
                _prevHealth = value;
            }
        }
        public delegate void HealthChangeDelegate(int health, int n); 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxHealth
        { 
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public int Health 
        { 
            get => _health; 
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Dead = true;
                    Console.WriteLine("Dude is dead");
                }
                else
                {
                    if (value > _maxHealth)
                        _health = _maxHealth;
                    else
                    {
                        _health = value;
                       
                        if (_health < _prevHealth)
                        {
                            int n = _prevHealth - _health;
                            HealthLowEvent.Invoke(_health, n);
                        }
                        else
                        {
                            if (_health > _prevHealth)
                            {
                                int n = _health - _prevHealth;
                                HealthHighEvent.Invoke(_health, n);
                            }
                        }
                    }
                    //HealthChangeEvent.Invoke(value);
                }
            } 
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }
        public void Build()
        {
            Console.WriteLine("Is building something great");
        }

        public virtual void ShowInfo()
        {
            Console.Write($"Unit: {_name} Health: {_health}/{_maxHealth} ");
        }
        //public event HealthChangeDelegate HealthChangeEvent;
        public event HealthChangeDelegate HealthLowEvent;
        public event HealthChangeDelegate HealthHighEvent;
    }
}
