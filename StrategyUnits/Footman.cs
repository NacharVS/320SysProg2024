namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {

        public Footman() : base(10, "Footman", 7)
        {

        }

        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= Damage;
        }

    }
}
