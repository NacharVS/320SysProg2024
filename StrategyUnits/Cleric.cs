namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric() : base(40, "Cleric", 3, 20)
        {
        }

        public void HillOthers(Unit unit) //Метод ЛеченияДругого
        {
            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (unit.Health == 0)
                {
                    Console.WriteLine($"Невозможно восстановить здоровье {unit.Name}. Он мёртв.");
                }
                else if (Manna < 2)
                {
                    Console.WriteLine("Недостаточно манны.");
                }
                else
                {
                    while (Manna >= 2 && unit.Health != unit.MaxHealth)
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                    Console.WriteLine($"{unit.Name} было восстановлено здоровье.");
                }
            }
        }

        public void HillMyself(Cleric cleric) //Метод ЛеченияСебя
        {
            if (IsDead == true)
            {
                Console.WriteLine("Cleric мёртв.");
            }
            else
            {
                if (Manna == 0)
                    Console.WriteLine("Недостаточно манны.");
                else
                {
                    while (Manna >= 1 && cleric.Health != cleric.MaxHealth)
                    {
                        cleric.Health += 2;
                        Manna -= 1;
                    }
                    Console.WriteLine($"{cleric.Name} было восстановлено здоровье.");
                }
            }
        }

        // Метод регенарции манны
        //public void RegenerationManna(Cleric cleric)
        //{
        //    Console.WriteLine($"{Name} восстанавливает манну...");
        //    DateTime fixDate = DateTime.Now;
        //    DateTime nextMinute = fixDate.AddSeconds(5);
        //    while (true)
        //    {
        //        DateTime now = DateTime.Now;
        //        if (now >= nextMinute)
        //        {
        //            Console.WriteLine($"{Name} восстановил манну с {_manna} до {MaxManna}");
        //            _manna = MaxManna;
        //            nextMinute = nextMinute.AddSeconds(5);
        //            break;
        //        }
        //    }

        //}
    }
}