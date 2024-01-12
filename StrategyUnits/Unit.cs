namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;

        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health 
        { 
            get => _health; 
            set => _health = value; 
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }
    }
}
