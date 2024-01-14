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
            if (unit == this)
            {
                while (Mana >= 1)
                {
                    Health += Heal * 2;
                    Mana -= 1;
                    Console.WriteLine("Клирик вылечил себе здоровье");
                }
            }
            else
            {
                while (Mana >= 2 && unit.Health < unit._maxHealth)
                {
                    unit.Health += Heal;
                    Mana -= 2;
                    Console.WriteLine($"Клирик вылечил {unit.Name}");
                }
            }
        }
       
    }


}

