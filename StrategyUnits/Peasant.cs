namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public bool IsWorking { get; set; }

        public Peasant() : base(30, "Peasant")
        {
            IsWorking = false;
        }

        public void PlowField()
        {
            if (IsWorking)
            {
                Console.WriteLine("Крестьянин уже занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин приступил к вспашке поля.");
                IsWorking = true;
            }
        }

        public void FinishWork()
        {
            if (IsWorking)
            {
                Console.WriteLine("Крестьянин закончил работу.");
                IsWorking = false;
            }
            else
            {
                Console.WriteLine("Крестьянин не работает сейчас.");
            }
        }
    }
}
