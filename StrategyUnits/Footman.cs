namespace StrategyUnits
{
    internal class Footman : MilitaryUnit 
    {
        public Footman( int health, string?  Name, int Damage) : base (Damage, Name, health)
        {
            
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine();
        }
    } 
}
