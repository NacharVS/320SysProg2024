using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Palladin : ZeelotKnight, IMagicAttack
    {
        private int _magicdamage;
        public int MagicDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Palladin (string? name,int health,  int armor, int damage, int magicdamage, int manna) : base( name, health, armor, damage, manna)
        {
            _magicdamage = magicdamage;
        }

        public void MagicAttack(IHealth unit) //Метод НанесенияМагическогоУрона(СвятойОгонь) (5 манны = 15)
        {
            if (!IsDead)
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
                    { Console.WriteLine($"Урон невозможен. Защищаюсийся мёртв."); }
                    else
                    {
                        DecreaseManna(5);
                        unit.DecreaseHealth(15);
                    Console.WriteLine($"{Name} использовал заклинание 'Святой Огонь'.");
                    }
            }
        }

        //public void HillyArmor(Unit unit) //Метод СвятаяБроня - Прибавляет защиту: 1 защита = 3 манны
        //{
        //    if (IsDead == true)
        //    {
        //        Console.WriteLine($"{Name} мёртв.");
        //    }
        //    else if (Manna < 3)
        //    {
        //        Console.WriteLine("Недостаточно манны.");
        //    }
        //    else
        //    {
        //        if (unit.IsDead == true || unit.Health <= 0)
        //        { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
        //        else
        //        {
        //            unit.Armor += 1;
        //            Manna -= 3;
        //            Console.WriteLine($"{Name} использовал заклинание 'Святая Броня' для {unit.Name}. Его текущая защита: {unit.Armor}");
        //        }
        //    }
        //}
    }
}
