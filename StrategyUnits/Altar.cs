using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Altar : IMagicUnit
    {
        private string? _nameA;
        private int _Energy;

        public event IMagicUnit.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnit.MannaChangedDelegate MannaIncreasedEvent;

        public int MaxEnergy { get; private set; }

        public Altar()
        {
            _nameA = "Алтарь Манны.";
            _Energy = 5000;
            MaxEnergy = _Energy;
        }

        public string NameA
        { 
            get { return _nameA; } 
            set { _nameA = value; } 
        }

        public int Energy
        {
            get => _Energy;
            set
            {
                if (value < 0)
                    _Energy = 0;
                else
                    if (value > MaxEnergy)
                        _Energy = MaxEnergy;
                    else
                        _Energy = value;
            }
        }

        public int Manna { get; set ; }
        public int MaxManna { get; set; }

        //Метод регенарции манны
        public void RegenerationManna(IMagicUnit magicUnit)
        {
            if (magicUnit.Manna == magicUnit.MaxManna)
                Console.WriteLine($"Максимальное значение манны.");
            else
            {
                Console.WriteLine($"{NameA} восстанавливает манну...");
                DateTime fixDate = DateTime.Now;
                DateTime nextMinute = fixDate.AddSeconds(2);
                while (true)
                {
                    DateTime now = DateTime.Now;
                    if (now >= nextMinute)
                    {
                        Console.WriteLine($"{NameA} восстановил манну с {magicUnit.Manna} до {magicUnit.MaxManna}");
                        Energy -= (magicUnit.MaxManna - magicUnit.Manna) / 10; // 1 Энергия = 10 Манны
                        magicUnit.Manna = magicUnit.MaxManna;
                        nextMinute = nextMinute.AddSeconds(2);
                        break;
                    }
                }
            }


        }

        public void ShowInfoAltar()
        {
            Console.WriteLine($"Текущее количество энергии {NameA}: {Energy}.");
        }

        //СОЗДАНИЕ ЮНИТОВ С МАГИЕЙ----------------------------------------------------------------------------
        public Cleric CreateCleric() //Создание клериков
        {
            return new Cleric( "Cleric", 45, 3, 5, 20); //Имя, здоровье, урон, магич урон, манна
        }

        public Palladin CreatePalladin()
        {
            return new Palladin("Palladin", 95, 10, 7, 10, 35);
        }

        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight( "Zeelot Knight", 70, 3, 5, 15); //Имя, здоровье, урон, защита, манна
        }

        public void DecreaseManna(int manna)
        {
            throw new NotImplementedException();
        }

        public void IncreaseManna(int manna)
        {
            throw new NotImplementedException();
        }
    }
}
