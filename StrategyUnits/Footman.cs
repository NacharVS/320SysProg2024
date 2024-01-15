namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private String _nameOfUnit;

        public Footman(String nameOfUnit) : base(60, "Footman", 2, 0, 7)
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
            Console.WriteLine($"====== CHARACTER ========\n" +
                $"{NameOfUnit} - a unit of {this.NameOfClass} class\n" +
               $"Health: {this.CurrentHealth}/{MaxHealth}\n" +
               $"Defense: {this.Defense}\n" +
               $"Damage (min - max): {this.MinDamage} - {this.MaxDamage}\n" +
               $"====== ========= ========\n");
        }
    }
}
