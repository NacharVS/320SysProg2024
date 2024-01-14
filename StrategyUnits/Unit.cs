namespace StrategyUnits
{
    internal class Unit
    {

        private int _health;
        private string? _name;
        private int _mana;
        public int _maxHealth {  get; set; }
        public int _maxMana {  get; set; }
        public bool _active;

        public Unit(int health, string? name, int mana, bool active)
        {
            _health = health;
            _name = name;
            _mana = mana;
            _maxHealth = _health;
            _maxMana = _mana;
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

        public void ShowInfo()
        {
            if(!_active)
            {
                Console.WriteLine($"{_name} Пчел мёртв");
            }
            else
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
