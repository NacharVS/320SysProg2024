using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Altar
    {
        private string? _nameA;
        private int _Energy;

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

        //Метод регенарции манны
        public void RegenerationManna(IMagicUnit magicUnit)
        {
            if (magicUnit.Manna == magicUnit.MaxManna)
                Console.WriteLine($"Максимальное значение манны.");
            else
            {
                Console.WriteLine($"{NameA} восстанавливает манну...");
                DateTime fixDate = DateTime.Now;
                DateTime nextMinute = fixDate.AddSeconds(1);
                while (true)
                {
                    DateTime now = DateTime.Now;
                    if (now >= nextMinute)
                    {
                        Console.WriteLine($"{NameA} восстановил манну с {magicUnit.Manna} до {magicUnit.MaxManna}");
                        _Energy -= (magicUnit.MaxManna - magicUnit.Manna) ; // 1 Энергия = 10 Манны
                        magicUnit.Manna = magicUnit.MaxManna;
                        nextMinute = nextMinute.AddSeconds(1);
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
            return new Palladin("Palladin", 95, 10, 7, 35);
        }

        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight( "Zeelot Knight", 70, 3, 5, 15); //Имя, здоровье, урон, защита, манна
        }
    }
}
