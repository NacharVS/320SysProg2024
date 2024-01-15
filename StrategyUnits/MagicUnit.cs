namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        public int MaxManna { get; private set; }


        public int Manna
        {
            get { return _manna; }
            set
            {
                if (value < 0)
                    _manna = 0;
                else
                    if (value > MaxManna)
                    _manna = MaxManna;
                else
                    _manna = value;
            }
        }

        public MagicUnit(int health, string? name, int damage, int manna) : base (health, name, damage)
        {
            _manna = manna;
        }

        public void GetInfoManna()
        {
            Console.WriteLine($"Текущая манна {Name}: {Manna}");
        }
    }
}
