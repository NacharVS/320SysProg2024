namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman() : base(60, "Footman", 7)
        {
        }

        public override void InflictDamage(Unit unit)
        {
            Console.WriteLine($"{Name} ударил мечом {unit.Name}");
            base.InflictDamage(unit);
        }
    }
}
