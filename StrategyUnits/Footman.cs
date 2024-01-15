namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private String _nameOfUnit;

        public Footman(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage) : base(60, "Footman", 2, 0, 7)
        {
        }

        public String NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }
        public override void Attack(Unit attackedUnit)
        {
            Random rnd = new Random();
            int appliedDamage = rnd.Next(this.MinDamage, this.MaxDamage) - attackedUnit.Defense;
            if (appliedDamage >= 0)
            {
                attackedUnit.CurrentHealth -= appliedDamage;
                Console.WriteLine($"Attack successful. You've applied {appliedDamage} DP.");
            }
        }
    }
}
