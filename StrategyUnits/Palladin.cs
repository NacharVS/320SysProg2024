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
            else if (Manna < 5)
            {
                Console.WriteLine("Недостаточно манны.");
            }
            else
            {
                    if(unit.Health == 0)
                    { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
                    else
                    {
                        unit.Health -= 15;
                        Manna -= 5;
                        Console.WriteLine($"Palladin нанес Магический урон {unit.Name}");
                    }
            }
        }
    }
}
