namespace StrategyUnits
{
<<<<<<< Updated upstream
    internal class Footman : MilitaryUnit
    {
        public Footman() : base(10, 20, 70, "Footman")
        {
            
=======
    internal class Footman : MillitaryUnit
    {
        public Footman(int minDamage, int maxDamage, string? name, int Health, int protection) : base(minDamage, maxDamage, name, Health, protection)
        {
>>>>>>> Stashed changes
        }
    }
}
