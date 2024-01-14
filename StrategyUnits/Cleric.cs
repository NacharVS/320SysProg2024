using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _manna;
        public int MaxManna { get; private set; }


        public int Manna
        {
            get { return _manna; }
            set
            {
                if (value < 0)
                    _manna = 0;
                else
                    if (value > MaxManna)
                    _manna = MaxManna;
                else
                    _manna = value;
            }
        }

        public Cleric() : base(40, "Cleric")
        {
            _manna = 20;
            MaxManna = _manna;
        }

        public void HillOthers(Unit unit) //Метод ЛеченияДругого
        {
            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (unit.Health == 0)
                {
                    Console.WriteLine($"Невозможно восстановить здоровье {unit.Name}. Он мёртв.");
                }
                else if (_manna < 2)
                {
                    Console.WriteLine("Недостаточно манны.");
                }
                else
                {
                    while (_manna >= 2 && unit.Health != unit.MaxHealth)
                    {
                        unit.Health += 1;
                        _manna -= 2;
                    }
                    Console.WriteLine($"{unit.Name} было восстановлено здоровье.");
                }
            }
        }

        public void HillMyself(Cleric cleric) //Метод ЛеченияСебя
        {
            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (_manna == 0)
                    Console.WriteLine("Недостаточно манны.");
                else
                {
                    while (_manna >= 1 && cleric.Health != cleric.MaxHealth)
                    {
                        cleric.Health += 2;
                        _manna -= 1;
                    }
                    Console.WriteLine($"{cleric.Name} было восстановлено здоровье.");
                }
            }
        }

        public void RegenerationManna(Cleric cleric)
        {
            Console.WriteLine($"{Name} восстанавливает манну...");
            DateTime fixDate = DateTime.Now;
            DateTime nextMinute = fixDate.AddSeconds(5);
            while (true)
            {
                DateTime now = DateTime.Now;
                if (now >= nextMinute)
                {
                    Console.WriteLine($"{Name} восстановил манну с {_manna} до {MaxManna}");
                    _manna = MaxManna;
                    nextMinute = nextMinute.AddSeconds(5);
                    break;
                }
            }

        }

        public void GetInfoCleric()
        {
            Console.WriteLine($"Текущая манна {Name}: {_manna}");
        }
    }
}