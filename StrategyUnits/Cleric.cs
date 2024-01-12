namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _selfheal;
        private int _otherheal;
        private int _mana;

        public int SelfHeal
        {
            get { return _selfheal; }
            set { _selfheal = value; }
        }

        public int OtherHeal
        {
            get { return _otherheal; }
            set { _otherheal = value; }
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        
        public Cleric() : base(50, 50, "Cleric")
        {
            _selfheal = 2;
            _otherheal = 1;
            _mana = 100;
        }

        public void InflictHeal(Unit unit)
        {
            while (_mana > 0)
            {
                if (unit.CurrentHP < _maxHP && unit.CurrentHP > 0)
                {
                    unit.CurrentHP += _otherheal;
                    _mana = _mana - 2;
                }

                if (CurrentHP < _maxHP && unit.CurrentHP > 0)
                {
                    CurrentHP += _selfheal;
                    _mana = _mana - 1;
                } 
            }
            Console.WriteLine("You haven't mana.");
        }
    }
}
