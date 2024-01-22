namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int _prevHealth;
        public bool Rrage { get; set; }
        private bool _rage = false;
        public bool Dead { get; set; }
        private bool _dead = false;
        public int _maxHealth;
        private int _suitHP;
        private bool _suit = false;
        public bool Suit {  get => _suit; set => _suit = value ; }
        public int SuitHP
        {
            get => _suitHP;
            set => _suitHP = value;
        }
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
        public delegate void HealthChangeDelegate(int health, int n, string? name);
        public delegate void Rage(int health);
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        public int MaxHealth
        { 
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }
        public virtual int Health
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
                        double percent = Math.Round(((double)_health / (double)_maxHealth), 3);
                        Console.WriteLine("HP: " + (percent * 100).ToString() + "%");
                        if (Suit == false) {
                            if (_health < _prevHealth)
                        {
                            int n = _prevHealth - _health;
                            HealthLowEvent.Invoke(_health, n, _name);
                        }
                        else
                        {
                            if (_health > _prevHealth)
                            {
                                int n = _health - _prevHealth;
                                HealthHighEvent.Invoke(_health, n, _name);
                            }
                        }
                        if ((percent < 0.5) && Name == "Berserker")
                        {
                            StartRageEvent.Invoke(_health);
                            Rrage = true;
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
            Console.Write($"Unit: {_name} | Health: {_health}/{_maxHealth} ");
        }
        public void ProtectSuit()
        {
            Console.WriteLine("Protective suit is putting on");
            _suit = true;
            _suitHP = 20;
        }
        public event HealthChangeDelegate HealthChangeEvent;
        public event Rage StartRageEvent;
        public event HealthChangeDelegate HealthLowEvent;
        public event HealthChangeDelegate HealthHighEvent;
    }
}
