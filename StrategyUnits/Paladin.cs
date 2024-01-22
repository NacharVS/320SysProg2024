namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base("Paladin", 80, 40, 10, 150) { }

        public void FireAttack(Unit unit)
        {
            if (DeadUnit == false)
            {
                if (Mana < 5)
                {
                    Console.WriteLine("You don't have mana.");
                }
                else
                {
                    if (unit.CurrentHP == 0)
                    {
                        Console.WriteLine($"Unit {unit.Name} is dead. Damage can't be done.");
                    }
                    else
                    {
                        unit.CurrentHP -= 15;
                        Mana -= 5;
                        Console.WriteLine($"Paladin dealt Magic damage to {unit.Name}.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Paladin is dead.");
            }
        }
    }
}
