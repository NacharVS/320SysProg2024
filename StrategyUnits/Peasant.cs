namespace StrategyUnits
{
    internal class Peasant : Unit
    {

        public Peasant() : base(30, "Peasant")
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
