namespace StrategyUnits
{
    internal class ZeelotKnight : MagicUnit
    {
        public ZeelotKnight(int health, string? name, int armor, int damage, int manna) : base(health, name, armor, damage, manna)
        {
        }

        public virtual void MagicAttack(Unit unit) //Метод НанесенияМагическогоУрона (2 манны = 8 урона)
        {
            if (IsDead == true)
            {
                Console.WriteLine($"{Name} мёртв.");
            }
            else if (Manna < 2)
            {
                Console.WriteLine("Недостаточно манны.");
            }
            else
            {
                if (unit.IsDead == true || unit.Health <= 0)
                { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
                else
                {
                    unit.Health -= 8;
                    Manna -= 2;
                    Console.WriteLine($"{Name} нанес Магический урон {unit.Name}");
                }
            }
        }
    }
}
