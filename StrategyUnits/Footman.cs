namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private String _nameOfUnit;

        public Footman(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, string nameOfUnit) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage)
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"====== CHARACTER ========\n" +
                $"{NameOfUnit} - a unit of {this.NameOfClass} class\n" +
               $"Health: {this.CurrentHealth}/{MaxHealth}\n" +
               $"Defense: {this.Defense}\n" +
               $"Damage (min - max): {this.MinDamage} - {this.MaxDamage}\n" +
               $"====== ========= ========\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
