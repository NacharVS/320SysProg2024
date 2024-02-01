namespace StrategyUnits.Units
{
    internal class Footman : MilitaryUnit
    {
        private string _nameOfUnit;
        public Footman(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int v, string nameOfUnit, int ArmorLevel, int WeaponLevel) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, ArmorLevel, WeaponLevel)
        {
            _nameOfUnit = nameOfUnit;
        }

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{NameOfUnit} - юнит" +
               $"Здоровье: {CurrentHealth}/{MaxHealth}\n" +
               $"Броня: {Defense}\n" +
               $"Урон (Мин - Макс): {MinDamage} - {MaxDamage}\n");

        }
    }
}
