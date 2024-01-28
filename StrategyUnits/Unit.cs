namespace StrategyUnits
{
    internal class Unit: IHealth, IMoving
    {
        private string? _name;
 
        ////private bool _deadperson;
        ////private int _levelArmor;
        ////private int _levelWeapon;
        //private int _guard;
        public Unit(string? name, int change_health, bool  deadperson, int maxHealth)
        {
            //    Name = name;
            //    Health = health;
            //    MaxHealth = maxHealth;
            _name = name;
            DeadPerson = deadperson;
            _change_health = change_health;
            MaxHealth = maxHealth;
            
            //    //_levelArmor = 0;
            //    //_levelWeapon = 0;
            //    //_guard = guard;
        }
        public int MaxHealth { get; set; }
        private int _change_health { get; set; }
        public bool DeadPerson { get; set; }

        //public void TakeDamage(int damage)
        //{
        //    Health -= damage;
        //}
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

        public int Change_Health
        {
            get => _change_health;
            set
            {
                int begin_health = _change_health;

                if (value < 0)
                {
                    _change_health = 0;
                    DeadPerson = true;
                    Console.WriteLine("Character is dead.You can't damage.");
                }
                else
                   if (value > MaxHealth)
                    _change_health = MaxHealth;
                else
                    _change_health = value;

                if (value <= begin_health)
                {
                    HealthDecreasedEvent.Invoke(_change_health, Name, (begin_health - value), MaxHealth);
                }
                else if (value > begin_health)
                {
                    HealthIncreasedEvent.Invoke(_change_health, Name, (value - begin_health), MaxHealth);
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        //public delegate void HealthChangeDelegate(int health, string name, int manna, int guard);
        public virtual void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name}");
            Console.WriteLine();
        }


        public void DecreaseHealth(int damage)
        {
            Change_Health -= damage;
        }

        public void IncreaseHealth(int health)
        {
            Change_Health += health;
        }
        public event IHealth.HealthChangeDelegate HealthDecreasedEvent;
        public event IHealth.HealthChangeDelegate HealthIncreasedEvent;

    }
}
