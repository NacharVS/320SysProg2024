using System;


namespace StrategyUnits
{
    internal class Cliric: Unit
    {
            private int _healthValue;

            public int Heal
            {
                get { return _healthValue; }
                set { _healthValue = value; }
            }

            public Cliric() : base(80, "Clirc")
            {
                _healthValue = 10;
            }

            public void InflictHeal(Unit unit)
            {
                unit.Health += _healthValue;
            }

        
    }
}
