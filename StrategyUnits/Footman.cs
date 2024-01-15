namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private String _nameOfUnit;

        public Footman(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
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
