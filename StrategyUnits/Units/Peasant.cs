using StrategyUnits.Interfaces;

namespace StrategyUnits.Units
{
    internal class Peasant : Unit, IPeaceful
    {
        public Peasant(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {
            IsWorking = IsWorking;
        }
        public bool IsWorking { get; set; }


        public void Build()
        {
            Console.WriteLine("Строит");
        }



        public void Dig()
        {
            Console.WriteLine("Копает");
        }

        public void EndWork()
        {
            if (IsDead)
            {
                Console.WriteLine("Мирный житель мертв. Он не может закончить работу");
                return;
            }
            if (IsWorking)
            {

                Console.WriteLine("Мирный житель закончил работу");
            }
            else
            {
                Console.WriteLine("Мирный житель сейчас свободен");
            }
        }

        public void StartWork()
        {
            if(IsDead)
            {
                Console.WriteLine("Мирный житель мертв");
                return;
            }
            if (IsWorking)
            {
                Console.WriteLine("Мирный житель занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин приступил к работе.");
                IsWorking = true;
            }
        }
    }
}
