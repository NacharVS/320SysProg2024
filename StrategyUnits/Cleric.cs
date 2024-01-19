using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
      
        public Cleric() : base(70, "Cleric", 5, 30)
        {

        }

        public void HillOthers(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                return;
            }

            while (Manna >= 2)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.WriteLine($"{unit.Name} hill.");
                    return;
                }
                else if (Manna < 2)
                {
                    Console.WriteLine("Not enough manna.");
                }
                else
                {
                    while (Manna >= 2)
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                    Hill_event.Invoke(Manna, unit.Health, Name, unit.Name);
                }
            }
        }

        public void HillMyself(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine($"{unit.Name} died, You can't hill dead characters.");
                return;
            }
            while (Manna > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.WriteLine($"{unit.Name} hill");
                    return;
                }
                else if (Manna < 1)
                {
                    Console.WriteLine("Not enough manna.");
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

        public delegate void HillDelegate (int manna, int health, string nameHiller_p, string nameHill_n);

        public event HillDelegate Hill_event;

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