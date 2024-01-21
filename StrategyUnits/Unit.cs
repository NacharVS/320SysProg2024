namespace StrategyUnits
{
    internal class Unit
    {
        private int _health; 
        private string? _name;
        private int _armor; 
        //private int _effectiveHP;
        public bool Alive { get; private set; }
        public int MaxHealth { get; private set; }
        public delegate void HealthChangedDelegate(int health, string name, int? manna, int? damage);
        public event HealthChangedDelegate HealthChangedEvent;
        public Unit(int health, string? name, int armor)
        {
            //_effectiveHP = MaxHealth * 10 / 100 * _armor + MaxHealth;
            _health = health;
            _name = name; 
            MaxHealth = health;
            Alive = true; 
            _armor = armor;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public int Health
        {
            get => _health; set
            {
                if (value < 0)
                {
                    _health = 0;
                    Alive = false;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }
        public virtual void ShowInfo()
        {
            HealthChangedEvent.Invoke(_health, _name, null, null);
        }
    }
}