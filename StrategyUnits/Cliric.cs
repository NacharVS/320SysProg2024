using System;


namespace StrategyUnits
{
    internal class Cliric: Unit
    {
            private int _healthValue;
            public bool isCliric = true;

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
                
                unit.Health += _healthValue;
            }

        
    }
}
