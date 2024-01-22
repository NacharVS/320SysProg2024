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

        public void Prayer(ZeelotKnight zeelotKnight)
        {

            if (IsDead == true)
            {
                Console.WriteLine($"{zeelotKnight.Name} мёртв.");
                return;
            }
            else if (zeelotKnight.Manna >= 10)
            {
                zeelotKnight.Health += 20;
                Manna -= 10;
                Console.WriteLine($"{zeelotKnight.Name} использовал заклинание 'Молитва'. Его текущее здоровье: {zeelotKnight.Health}");
            }
            else
            {
                Console.WriteLine("Недостаточно манны.");
            }
        }
    }
}
