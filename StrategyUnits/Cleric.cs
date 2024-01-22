using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
      
        public Cleric(int health, string? name, int damage, int manna, int guard) : base(health, name, damage, manna, guard)
        {

        }

        public void HillOthers(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                Console.ResetColor();
                return;
            }
            else
            {
            while (Manna >= 2)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} hill.");
                    Console.ResetColor();
                    return;
                }
                else if (Manna < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Not enough manna.");
                    Console.ResetColor();
                }
                else
                {
                    while (Manna >= 2)
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                }
            }
            }


        }
        public void HillMyself(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                Console.ResetColor();
                return;
            }
            while (Manna > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{unit.Name} hill");
                    Console.ResetColor();
                    return;
                }
                else if (Manna < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Not enough manna.");
                    Console.ResetColor();
                }
                else
                    while (Manna >= 1)
                    {
                        unit.Health += 2;
                        Manna -= 1;
                    }
                Console.WriteLine($"Character {unit.Name} hill himself");
            }
        }

     

        //public event HillDelegate Hill_event;

        // манна, здоровье, пострадавший, нанесший
        //public void GetInfoCleric()
        //{
        //    Console.WriteLine($"Manna: {Manna}");
        //}
        //create event
    }
}
//Лечить себя: 1 мана = 2 здоровья
//Лечить ДРУГОГО : 2 маны = 1 здоровье