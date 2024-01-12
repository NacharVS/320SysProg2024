namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public bool IsWork { get; set; }
        public Peasant() : base(30, "Peasant")
        {
            IsWork = false;
        }
        public void Collect_wood()
        {
            if (IsWork)
            {
                Console.WriteLine("Крестьянин  занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин собирает древесину.");
                IsWork = true;
            }
        }
        public void Build()
        {
            if (IsWork)
            {
                Console.WriteLine("Крестьянин  занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин занят стройкой здания.");
                IsWork = true;
            }
        }
        public void Collect_food()
        {
            if (IsWork)
            {
                Console.WriteLine("Крестьянин  занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин собирает ягоды.");
                IsWork = true;
            }
        }
    }
}
