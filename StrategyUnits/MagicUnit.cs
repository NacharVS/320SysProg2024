namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _currentMana;
        private int _maximumMana;

        public int MaximumMana
        {
            get { return _maximumMana; }
            set { _maximumMana = value; }
        }

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
        public MagicUnit(int maxHP, string? name, int damage, int MaximumMana) : base(maxHP, name, damage)
        {
            _currentMana = MaximumMana;
            _maximumMana = MaximumMana;
    }
        //Метод нанесения урона
        public void GetInfoManna()
        {
            Console.WriteLine($"Current mana of {Name}: {Mana}");
        }
    }
}
