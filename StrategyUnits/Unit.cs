namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthChangedDelegate(string name, int health, int newHealth, int armor);

        private int _health;
        private string _name;
        private int _armor;

        public int MaxHealth { get; private set; }

        public Unit(int health, string name, int armor)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
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
            set
            {
                if (value <= 0)
                {
                    _armor = 0;
                }
                else
                {
                    _armor = value;
                }
            }
        }

        public int Health
        {
            get => _health;
            set
            {


                if (value > Health)
                {
                    HealthIncreasedEvent.Invoke(Name, Health, value, Armor);
                }
                else
                {
                    HealthDecreasedEvent.Invoke(Name, Health, value, Armor);
                }

                if (value < 0)
                {
                    _health = 0;
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
            Console.WriteLine($"Unit: {_name} Health: {_health} Armor: {_armor}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}