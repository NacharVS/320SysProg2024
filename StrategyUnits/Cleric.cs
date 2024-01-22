namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric(int health, string? name, int armor, int damage, int manna) : base(health, name, armor, damage, manna)
        {
        }

        public delegate void HillDelegate(int manna, int health, string nameHiller, string nameHill); //Делегат Хилла -- Хиллер, КогоХиллет

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
                    HillEvent.Invoke(Manna, unit.Health, Name, unit.Name);
                }
            }
        }

        public void HillMyself() //Метод ЛеченияСебя
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
                    while (Manna >= 1 && Health != MaxHealth)
                    {
                        Health += 2;
                        Manna -= 1;
                    }
                    HillEvent.Invoke(Manna, Health, Name, Name);
                }

            }
        }

        public event HillDelegate HillEvent; //Ивет Хилла
    }
}