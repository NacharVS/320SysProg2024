namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damage;

        public Footman(int maxHP, string? name, int damage) : base(maxHP, name, damage) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} Damage: {Damage} HP: {CurrentHP}/{MaximumHP}");
        }
    }
}
