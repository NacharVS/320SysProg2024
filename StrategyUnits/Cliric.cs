namespace StrategyUnits
{
    internal class Cliric : Unit
    {
        private int _healthValue;

        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }

        public Cliric() : base(80, "Clirc", 60, true)
        {
            _healthValue = 1;
        }

        public void InflictHeal(Unit unit)
        {
            if (Mana >= 2)
            {
                if (unit == this)
                {
                    unit.Health += Heal * 2;
                    unit.Mana -= 1;
                    Console.WriteLine("Клирик вылечил себе здоровье");
                }
                else
                {
                    unit.Health += Heal;
                    Mana -= 2;
                    Console.WriteLine($"Клирик вылечил {unit.Name}");
                }
            }
            else
                Console.WriteLine("Mana no");
        }


    }
}
