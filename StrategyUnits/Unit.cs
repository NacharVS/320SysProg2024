namespace StrategyUnits
{
    internal class Unit: IHealth, IMoving
    {
        private string? _name;
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public bool DeadPeson { get; set; }

        ////private bool _deadperson;
        ////private int _levelArmor;
        ////private int _levelWeapon;
        //private int _guard;
        //public Unit(int health, string name, int maxHealth)
        //{ 
        //    Name = name;
        //    Health = health;
        //    MaxHealth = maxHealth;

        //    //_health = health;
        //    //_name = name;
        //    //MaxHealth = _health;
        //    //_deadperson = false;
        //    //_levelArmor = 0;
        //    //_levelWeapon = 0;
        //    //_guard = guard;
        //}

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        //public virtual int Guard
        //{
        //    get { return _guard; }
        //    set { _guard = value; }
        //}
        ////public int LevelWeapon
        ////{
        ////    get { return _levelWeapon; }
        ////    set { _levelWeapon = value; }
        ////}

        ////public int LevellArmor
        ////{
        ////    get { return _levelArmor; }
        ////    set { _levelArmor = value; }
        ////}
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        ////public bool DeadPerson
        ////{
        ////    get { return _deadperson; }
        ////    set { _deadperson = value; }
        ////}

        ////public int Health 
        ////{ 
        ////    get => _health;
        ////    set
        ////    {
        ////        if (value < 0)
        ////        {
        ////            _health = 0;
        ////            _deadperson = true;
        ////            Console.WriteLine("Character is dead.You can't damage.");
        ////        }
        ////        else
        ////           if (value > MaxHealth)
        ////            _health = MaxHealth;
        ////        else
        ////            _health = value;

        ////        if (value <= _health)
        ////        {
        ////            HealthDecreasedEvent.Invoke(Health, Name, (MaxHealth - value), Guard);
        ////        }
        ////        else if (value > _health)
        ////        {
        ////            HealthIncreasedEvent.Invoke(Health, Name, (MaxHealth - value), Guard);
        ////        }
        ////    }
        ////}

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        ////public delegate void HealthChangeDelegate(int health, string name, int manna, int guard);
        public virtual void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} Health: {Health} Level Weapon: {_levelWeapon} Level Armor: {_levelArmor}");
            Console.WriteLine();
        }


        public void DecreaseHealth(int damage)
        {
            Health -= damage;
        }

        public void IncreaseHealth(int health)
        {
            Health += health;
        }
        ////public event HealthChangeDelegate HealthDecreasedEvent;
        ////public event HealthChangeDelegate HealthIncreasedEvent;

    }
}
