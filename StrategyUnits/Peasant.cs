namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {

        }

        public void Build()
        {
            Console.WriteLine("Строит");
        }

        public void Dig()
        {
            Console.WriteLine("Копает");
        }
    }
}
