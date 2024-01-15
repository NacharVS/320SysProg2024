namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _mana;
        public int MaximumMana { get; private set; }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaximumMana)
                    {
                        _mana = MaximumMana;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }

        public Cleric() : base(50, "Cleric")
        {
            _mana = 3;
        }
        public void SelfHeal(Unit unit)
        {
            if (DeadUnit == false)
            {
                if (_mana > 0)
                {
                    if (unit.CurrentHP < unit.MaximumHP)
                    {
                        CurrentHP += 2;
                        _mana--;
                    }
                    else
                    {
                        Console.WriteLine("You have enough HP.");
                    }
                }
                else
                {
                    Console.WriteLine("You don't have mana.");
                }
            }
            else
            {
                Console.WriteLine("You are dead. You can't heal yourself.");
                return;
            }
        }
        public void OtherHeal(Unit unit)
        {
            if (unit.DeadUnit == false)
            {
                if (_mana > 0)
                {
                    if (unit.CurrentHP < unit.MaximumHP)
                    {
                        unit.CurrentHP++;
                        _mana -= 2;
                    }
                    else
                    {
                        Console.WriteLine("Unit has enough HP.");
                    }
                }
                else
                {
                    Console.WriteLine("You don't have mana.");
                }
            }
            else
            {
                Console.WriteLine("Unit is dead. You can't heal him.");
                return;
            }
        }
        public void ShowInfoCleric()
        {
            Console.WriteLine($"Mana: {_mana}");
        }
    }
}
