namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public bool working;

        public bool WorkingUnit
        {
            get { return working; }
            set { working = value; }
        }
        public Peasant() : base("Peasant", 30, 4)
        {
            working = false;
        }

        public void Harvest()
        {
            if (working == false)
            {
                Console.WriteLine($"Персонаж приступил к собиранию урожая");
                working = true;
            }
            else
                Console.WriteLine($"Персонаж уже занят работой!");
        }

        public void CleaningTheArea()
        {
            if (working == false)
            {
                Console.WriteLine($"Персонаж приступил к уборке территории");
                working = true;
            }
            else
                Console.WriteLine($"Персонаж уже занят работой!");
        }

        public void EndOfWork()
        {
            if (working == true)
            {
                Console.WriteLine($"Персонаж освобожден от работы");
                working = false;
            }
            else
                Console.WriteLine($"Персонаж сейчас не занят");
        }
    }
}
