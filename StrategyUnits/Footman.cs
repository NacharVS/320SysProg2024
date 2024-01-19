namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, int damage, int protection) : base(health, name, damage, protection)
        {

        }

        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= (Damage - this.Protection);
        }
       
    }
}
