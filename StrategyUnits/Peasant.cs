using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Peasant : Unit, IPeasant
    {
        private int quantityResources;
        public int QuanResources
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
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("");
        }
    }
}
