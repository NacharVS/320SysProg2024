namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(95, "Palladin", 10, 35)
        {

        }

        public void MagicAttack(Unit unit) //Метод НанесенияМагическогоУрона (5 манны = 15)
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
