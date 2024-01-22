namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(string? name, int maxHP, int protection, int damage) : base(name, maxHP, protection, damage) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} Damage: {Damage} HP: {CurrentHP}/{MaximumHP} Protection {Protection}/{MaximumProtect}");
        }
    }
}
