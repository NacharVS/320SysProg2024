namespace StrategyUnits
{
    internal class Unit
    {

        private int _health;                                              //Здоровье
        private string? _name;                                            //Наименование
        private int _armor;                                               //Защита (броня).
        public bool? IsDead { get; private set; }                         //Мертв == true
        public int MaxHealth { get; private set; }                        //Максимальное здоровье
        public int MaxArmor { get; private set; }                         //Максимальная защита


        public Unit(int health, string? name, int armor)
        {
            _health = health;
            _name = name;
            _armor = armor;
            MaxHealth = _health;
            MaxArmor = _armor;
            IsDead = false;

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Armor
        {
            get => _armor;
            set
            {
                if (value < 0)
                {
                    _armor = 0;
                    Console.WriteLine($"Защита {Name} пробита.");
                }
                else
                   if (value > MaxArmor)
                    _armor = MaxArmor;
                else
                    _armor = value;
            }
        }

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    IsDead = true;
                    Console.WriteLine($"{Name} мёртв. Нанесения урона невозможно.");
                }
                else
                   if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Передвижение.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Защита: {Armor} Состоние жизни: {IsDead}");
        }

    }
}