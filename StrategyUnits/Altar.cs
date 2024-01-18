namespace StrategyUnits
{
    internal class Altar : Unit
    {
        private int _Energy;
        private int _MaxEnergy;

        public int MaxEnergy
            { get { return _Energy; } 
            set { _Energy = value; } 
        }

        public int Energy
        {
            get { return _Energy; }
            set
            {
                if (value < 0)
                    _Energy = 0;
                else
                    if (value > MaxEnergy)
                        _Energy = MaxEnergy;
                    else
                        _Energy = value;
            }
        }



        public Altar() : base (1000, "Алтарь Манны")
        {
        }
    }
}
