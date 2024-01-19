namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield)
        {
        }
    }
}
