namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _currentMana;
        public int MaximumMana { get; private set; }
        public int Mana
        {
            get { return _currentMana; }
            set
            {
                if ( value < 0)
                {
                    _currentMana = 0;
                }
                else
                {
                    if (_currentMana > MaximumMana)
                    {
                        _currentMana = MaximumMana;
                    }
                    else
                    {
                        _currentMana = value;
                    }
                }
            }
        }
        public MagicUnit(string? name, int maxHP, int protection, int damage, int maxMana) : base(name, maxHP, protection, damage)
        {
            MaximumMana = maxMana;
            _currentMana = MaximumMana;
        }
        public void GetInfoMana()
        {
            Console.WriteLine($"Current mana of {Name}: {Mana}");
        }
    }
}
