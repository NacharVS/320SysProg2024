using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Unit : IHealth, IMovihgUnit //Здоровье, Передвижение
    {
        private string? _name; //Имя
        private int _health;  //Здоровье

        public int MaxHealth { get; set; } //Максимальное Здоровье
        public bool IsDead { get; set; } //Статуст персонажа

        public Unit(string? name, int health)
        {
            _name = name;
            _health = health;
            MaxHealth = _health;
            IsDead = false;
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
                int begin_health = _health;

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

                if (value <= begin_health)
                {
                    HealthDecreasedEvent.Invoke(_health, Name, (begin_health - value), MaxHealth); //ТекЗдоровье, Имя, Потреря, Максимальное
                }
                else if (value > begin_health)
                {
                    HealthIncreasedEvent.Invoke(_health, Name, (value - begin_health), MaxHealth); // //ТекЗдоровье, Имя, Пополнение, Максимальное
                }
            }
        }//Здоровье

        public event IHealth.HealthChangeDelegate HealthDecreasedEvent;
        public event IHealth.HealthChangeDelegate HealthIncreasedEvent;

        public void DecreaseHealth(int damage) //Потеря
        {
            Health -= damage;
        }

        public void IncreseHealth(int health) //Пополнение
        {
            Health += health;
        }

        public void Move() //Передвижение
        {
            Console.WriteLine("Передвижение.");
        }

        public virtual void ShowInfo() //Показать инфу
        {
            //string sost;
            //if (!IsDead)
            //    sost = "жив.";
            //else
            //    sost = "мёртв";

            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health}\n");
        }



        //private int _health;                                              //Здоровье
        //private string? _name;                                            //Наименование
        //private int _armor;                                               //Защита (броня).
        //public bool? IsDead { get; private set; }                         //Мертв == true
        //public int MaxHealth { get; private set; }                        //Максимальное здоровье
        //private int _MaxArmor;                                            //Максимальная защита
        //internal int LeverDamage { get; set; } = 0;                         //Уровень Атаки
        //internal int LeverArmor { get; set; } = 0;                        //Уровень Защиты

        //public int MaxArmor
        //{
        //    get { return _armor; }
        //    set { _armor = value; }
        //}

        //public Unit(int health, string? name, int armor)
        //{
        //    _health = health;
        //    _name = name;
        //    _armor = armor;
        //    MaxHealth = _health;
        //    IsDead = false;

        //}

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //public int Armor
        //{
        //    get => _armor;
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _armor = 0;
        //            Console.WriteLine($"Защита {Name} пробита.");
        //        }
        //        else
        //           if (value > MaxArmor)
        //            _armor = MaxArmor;
        //        else
        //            _armor = value;
        //    }
        //}

        //public int Health
        //{
        //    get => _health;
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            IsDead = true;
        //            _health = 0;
        //            Console.WriteLine($"{Name} мёртв. Нанесения урона невозможно.");
        //        }
        //        else
        //           if (value > MaxHealth)
        //            _health = MaxHealth;
        //        else
        //            _health = value;
        //    }
        //}

        //public void Move()
        //{
        //    Console.WriteLine("Передвижение.");
        //}



    }
}