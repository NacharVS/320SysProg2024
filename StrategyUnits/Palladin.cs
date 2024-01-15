namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin () : base (95, "Palladin", 10, 35)
        {

        }

        public void MagicAttack(Unit unit) //Метод НанесенияМагическогоУрона (5 манны = 15)
        {
            if (IsDead == true)
            {
                Console.WriteLine("Palladin мёртв.");
            }
            else
            {
                if (Manna < 5)
                {
                    Console.WriteLine("Недостаточно манны.");
                }
                else
                {
                    unit.Health -= 15;
                    Manna -= 5;
                    Console.WriteLine($"Palladin нанес урон 15 {unit.Name}");
                }
            }
        }
    }
}
