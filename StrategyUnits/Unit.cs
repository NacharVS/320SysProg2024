namespace StrategyUnits
{
    internal class Unit
    {
        private string? _name;
        private int currentHP;
        public int _maxHP { get; private set; }

        public Unit(int maxHP, int hp, string? name)
        {
            _name = name;
            _maxHP = maxHP;
            currentHP = hp;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxHP
        {
            get => _maxHP;
            set => _maxHP = value;
        }

        public int CurrentHP
        { 
            get => currentHP; 
            set
            {
                if (value < 0)
                {
                    currentHP = 0;
                }
                else
                {
                    if (value > MaxHP)
                    {
                        currentHP = MaxHP;
                    }
                    else
                    {
                        currentHP = value; 
                    }
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {currentHP} MaxHealth: {_maxHP}");
        }
    }
}
