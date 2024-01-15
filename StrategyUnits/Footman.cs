namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman() : base(60, "Footman", 7)
        {
        }

        public override void InflictDamage(Unit unit)
        {
            base.InflictDamage(unit);
            Console.WriteLine("Пехотинец ударил мечом");
        }
    }
}
