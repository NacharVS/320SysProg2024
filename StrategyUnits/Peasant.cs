using StrategyUnits.Interfase;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant() : base(30, "Peasant")
        {
        }
        public void GoFishing()
        {
            Console.WriteLine($"{Name} идет на рыбалку");
        }
        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровье: {Health}");
            else
                Console.WriteLine($"{Name} мертв");
        }

    }
}
