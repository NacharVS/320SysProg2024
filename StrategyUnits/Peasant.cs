namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant() : base(30, "Peasant")
        {
        }
        public void GoFishing()
        {
            Console.WriteLine($"{Name} идет на рыбалку");
        }

    }
}
