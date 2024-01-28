using StrategyUnits.Inerfaces;

namespace StrategyUnits.Units
{
    internal class Peasant : Unit, ICivilian
    {
        public Peasant(string? name, bool isDied, double currentHealth, double maxHealth, bool isWorking) : base(name, isDied, currentHealth, maxHealth)
        {
            IsWorking = isWorking;
        }

        public bool IsWorking { get; set; }

        public void PlowField()
        {
            if (IsDied)
            {
                Console.WriteLine("Мирный житель мертв");
                return;
            }
            if (IsWorking)
            {
                Console.WriteLine("Крестьянин уже занят работой.");
            }
            else
            {
                Console.WriteLine("Крестьянин приступил к вспашке поля.");
                IsWorking = true;
            }
        }

        public void FinishWork()
        {
            if (IsDied)
            {
                Console.WriteLine("Мирный житель мертв");
                return;
            }
            if (IsWorking)
            {
                Console.WriteLine("Крестьянин закончил работу.");
                IsWorking = false;
            }
            else
            {
                Console.WriteLine("Крестьянин не работает сейчас.");
            }
        }
        public virtual void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n Здоровье: {CurrentHealth}/{MaxHealth} \n Живой: {!IsDied} \n Работает: {IsWorking}");
        }
    }
}
