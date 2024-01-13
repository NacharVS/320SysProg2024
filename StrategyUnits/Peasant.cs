using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        private int _mana;

        public int Mana { get => _mana; set => _mana = value; }

        public Peasant() : base(30, "Peasant")
        {
            _mana = 12;
        }

        public void HealSelf()
        {
            if (Health == 0)
            {
                Console.WriteLine($"Unit {Name} is already died.");
            }
            else if (_mana >= 1)
            {
                _mana -= 1;
                Health = Math.Min(MaxHealth, Health+2);
            }
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.Health == 0)
            {
                Console.WriteLine($"Unit {unit.Name} is already died.");
            }
            else if (_mana >= 2)
            {
                _mana -= 2;
                unit.Health = Math.Min(unit.MaxHealth, unit.Health + 1);
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}. Health: {Health}. Mana: {Mana}.");
        }
    }
}
