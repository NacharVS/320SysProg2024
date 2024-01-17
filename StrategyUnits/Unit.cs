namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(int health, string name, int action, int? mana);

        public event HealthChangedDelegate HealthChangeEvent;

        private int _health;
        private string? _name;
        public int _maxHealth {  get; set; }
        public bool _active;

        public Unit(int health, string? name, bool active)
        {
            _health = health;
            _name = name;
            _maxHealth = _health;
            _active = active;   
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        { 
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else
                    if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            if(!_active)
            {
                HealthChangeEvent.Invoke(_health, _name, 1, null);
            }
            else
                HealthChangeEvent.Invoke(_health, _name, 0, null);
        }

        

    }
}
