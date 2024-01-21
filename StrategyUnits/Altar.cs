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
        public void RegenerationManna(MagicUnit magicUnit)
        {
            Console.WriteLine($"{NameA} восстанавливает манну...");
            DateTime fixDate = DateTime.Now;
            DateTime nextMinute = fixDate.AddSeconds(5);
            while (true)
            {
                DateTime now = DateTime.Now;
                if (now >= nextMinute)
                {
                    Console.WriteLine($"{NameA} восстановил манну с {magicUnit.Manna} до {magicUnit.MaxManna}");
                    Energy -= (magicUnit.MaxManna - magicUnit.Manna) / 10; // 1 Энергия = 10 Манны
                    magicUnit.Manna = magicUnit.MaxManna;
                    nextMinute = nextMinute.AddSeconds(5);
                    break;
                }
            }

        }

        public void ShowInfoAltar()
        {
            Console.WriteLine($"Текущее количество энергии {NameA}: {Energy}.");
        }

        public Cleric CreateCleric() //Рекрут
        {
            return new Cleric(45, "Recruit", 5, 9);
        }

    }
}
