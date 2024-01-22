namespace StrategyUnits
{
    internal class Palladin : ZeelotKnight
    {
        public Palladin (int health, string? name, int armor, int damage, int manna) : base(health, name, armor, damage, manna)
        {

        }

        public override void MagicAttack(Unit unit) //Метод НанесенияМагическогоУрона(СвятойОгонь) (5 манны = 15)
        {
            if (IsDead == true)
            {
                Console.WriteLine($"{Name} мёртв.");
            }
            else if (Manna < 5)
            {
                Console.WriteLine("Недостаточно манны.");
            }
            else
            {
                    if(unit.IsDead == true || unit.Health <= 0)
                    { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
                    else
                    {
                        unit.Health -= 15;
                        Manna -= 5;
                        Console.WriteLine($"{Name} использовал заклинание 'Святой Огонь' для {unit.Name}.");
                    }
            }
        }

        public void HillyArmor(Unit unit) //Метод СвятаяБроня - Прибавляет защиту: 1 защита = 3 манны
        {
            if (IsDead == true)
            {
                Console.WriteLine($"{Name} мёртв.");
            }
            else if (Manna < 3)
            {
                Console.WriteLine("Недостаточно манны.");
            }
            else
            {
                if (unit.IsDead == true || unit.Health <= 0)
                { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
                else
                {
                    unit.Armor += 1;
                    Manna -= 3;
                    Console.WriteLine($"{Name} использовал заклинание 'Святая Броня' для {unit.Name}. Его текущая защита: {unit.Armor}");
                }
            }
        }
    }
}
