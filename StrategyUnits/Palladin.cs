using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Palladin : ZeelotKnight, IMagicAttack
    {
        public Palladin (string? name, int health, int magicdamage, int armor, int manna) : base( name, health, magicdamage, armor,  manna)
        {

        }

        public override void MagicAttack(IHealth unit) //Метод НанесенияМагическогоУрона(СвятойОгонь) (5 манны = 15)
        {
            //if (IsDead)
            //{
            //    Console.WriteLine($"{Name} мёртв.");
            //}
            /*else */if (Manna < 5)
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

        public void HillyArmor() //Метод СвятаяБроня - Увеличивает защиту: 1 защита = 3 манны
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
                Armor += 1;
                Manna -= 3;
                Console.WriteLine($"{Name} использовал заклинание 'Святая Броня'. Его текущая защита: {Armor}");
            }
        }

        public override void ShowInfo() //Показать инфу
        {

            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Атака: {MagicDamage} Защита: {Armor}\n");
        }
    }
}
