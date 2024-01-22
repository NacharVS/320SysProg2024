namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric() : base("Cleric", 50, 20, 5, 90) { }
        public void Heal(Unit unit)
        {
            if (unit.DeadUnit == false)
            {
                if (Mana > 2)
                {
                    while (unit.CurrentHP < unit.MaximumHP)
                    {
                        unit.CurrentHP++;
                        Mana -= 2;
                    }
                    HealEvent.Invoke(Mana, unit.CurrentHP, Name, unit.Name);
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
            Console.WriteLine($"Mana: {Mana}");
        }

        public delegate void HealDelegate(int mana, int maxHP, string nameHealer, string nameHealing);

        public event HealDelegate HealEvent;
    }
}
