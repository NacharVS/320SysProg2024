namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public int quantityResources;
        public int QuanRecources
        { get { return quantityResources;  } 
          set { quantityResources = value; } }
        public Peasant() : base(30, "Peasant")
        {
            quantityResources = 0;
        }
        public void Collecting()
        {
            Console.WriteLine("Is collecting resources");
            quantityResources++;
            Console.WriteLine($"Quantity of resources is {quantityResources.ToString()}");
        }
    }
}
