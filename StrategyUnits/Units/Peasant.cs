namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {
        }

        public void Build()
        {
            Console.WriteLine("Is building");
        }

        public void Dig()
        {
            Console.WriteLine("Is digging");
        }

        public void Chop()
        {
            Console.WriteLine("Is chopping");
        }

        public void CollectFood()
        {
            Console.WriteLine("Is collecting food");
        }
    }
}
