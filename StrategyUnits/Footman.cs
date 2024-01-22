namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private String _nameOfUnit;
        public Footman(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int v, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage)
        {
            _nameOfUnit = nameOfUnit;
        }

        public String NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{NameOfUnit} - юнит {NameOfClass} класса \n" +
               $"Здоровье: {CurrentHealth}/{MaxHealth}\n" +
               $"Броня: {Defense}\n" +
               $"Урон (Мин - Макс): {MinDamage} - {MaxDamage}\n");
           
        }
    }
}
