namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(double health, string? name, double damage, double protection) : base(health, name, damage, protection)
        {

        }

        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= (this.Damage - unit.Protection);
        }
       
    }
}
