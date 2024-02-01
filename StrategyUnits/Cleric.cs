using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Cleric : Unit, IMagicUnit, IInflictDamage, IHill
    {
        private int _manna;
        private int _damage;
        public Cleric( string? name,int health, int damage, int magicDamage, int manna) : base( name, health)
        {
            _manna = manna;
            _damage = damage;
            MaxManna = _manna;
        }

        public int Manna
        {
            get { return _manna; }
            set
            {
                int beginManna = _manna;
                if (value < 0)
                {
                    _manna = 0;
                }
                else
                {
                    if (value > MaxManna)
                        _manna = MaxManna;
                    else
                        _manna = value;
                }
                if (value < beginManna)
                {
                    MannaDecreasedEvent.Invoke( this.Name, beginManna - value, Manna, MaxManna);
                }
                else if (value > beginManna)
                {
                    MannaIncreasedEvent.Invoke( this.Name, value - beginManna, Manna, MaxManna);
                }
            }
        }
        public int MaxManna { get; set; }
        public int Damage
        {
            get => IInflictDamage.LevelWeapon * 2 + _damage;
            set => _damage = value;
        }

        public event IMagicUnit.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnit.MannaChangedDelegate MannaIncreasedEvent;

        public void DecreaseManna(int manna)
        {
            Manna -= 2;
        }

        public void HillOthers(IHealth health)
        {

            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (health.Health == 0)
                {
                    Console.WriteLine($"Невозможно восстановить здоровье.");
                }
                else if (Manna < 2)
                {
                    Console.WriteLine("Недостаточно манны.");
                }
                else
                {
                    while (Manna >= 2 && health.Health != health.MaxHealth)
                    {
                        health.IncreseHealth(1);
                        DecreaseManna(2);

                    }
                }
            }
        }

        public void HillMyself() //Метод ЛеченияСебя
        {
            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (Manna == 0)
                    Console.WriteLine("Недостаточно манны.");
                else
                {
                    while (Manna >= 1 && Health != MaxHealth)
                    {
                        Health += 2;
                        Manna -= 1;
                    }
                }

            }
        }

        public void IncreaseManna(int manna)
        {
            Manna += manna;
        }

        public void InflictDamage(IHealth health)
        {
            Console.WriteLine($"{Name} атаковал.");
            health.DecreaseHealth(Damage);
        }


        //public delegate void HillDelegate(int manna, int health, string nameHiller, string nameHill); //Делегат Хилла -- Хиллер, КогоХиллет

        //public void HillOthers(Unit unit) //Метод ЛеченияДругого
        //{
        //    if (IsDead == true)
        //    {
        //        Console.WriteLine("Cleric мёртв.");
        //    }
        //    else
        //    {
        //        if (unit.Health == 0)
        //        {
        //            Console.WriteLine($"Невозможно восстановить здоровье {unit.Name}. Он мёртв.");
        //        }
        //        else if (Manna < 2)
        //        {
        //            Console.WriteLine("Недостаточно манны.");
        //        }
        //        else
        //        {
        //            while (Manna >= 2 && unit.Health != unit.MaxHealth)
        //            {
        //                unit.Health += 1;
        //                Manna -= 2;

        //            }
        //            HillEvent.Invoke(Manna, unit.Health, Name, unit.Name);
        //        }
        //    }
        //}



        //public event HillDelegate HillEvent; //Ивет Хилла
    }
}