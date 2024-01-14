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
                Console.WriteLine("Первонаж мертв");
            }
            else
            {
                if (unit.Health == 0)
                {
                    Console.WriteLine("You can't hill dead characters.");
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
                }
            }
        }

        public void HillMyself(Cleric cleric) //Метод ЛеченияСебя
        {
            if (IsDead == true)
            {
                Console.WriteLine("Первонаж мертв");
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
            Console.WriteLine($"{Name} мanna: {_manna}");
        }
    }
}