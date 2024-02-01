using StrategyUnits.Interface;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class ZeelotKnight : Unit, IMagicUnit, IArmor, IMagicAttack
    {
        private int _manna;
        public int MaxManna { get; set; }
        private int _magicdamage;
        private int _armor;
        public ZeelotKnight(string? name,int health, int magicdamage, int armor,  int manna) : base(name, health)
        {
            _manna = manna;
            MaxManna = manna;
            _magicdamage = magicdamage;
            _armor = armor;
        }

        public int Manna
        {
            get { return _manna; }
            set
            {
                int beginManna = _manna;
                if (value < 0)
                {
                    _manna = 0;
                }
                else
                {
                    if (value > MaxManna)
                        _manna = MaxManna;
                    else
                        _manna = value;
                }
                if (value < beginManna)
                {
                    MannaDecreasedEvent.Invoke(this.Name, beginManna - value, Manna, MaxManna);
                }
                else if (value > beginManna)
                {
                    MannaIncreasedEvent.Invoke(this.Name, value - beginManna, Manna, MaxManna);
                }
            }
        }

        public int Armor
        {
            get => IArmor.LevelArmor * 2 + _armor;
            set => _armor = value;
        }
        public int MagicDamage { get => _magicdamage; set => _magicdamage = value; }

        public event IMagicUnit.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnit.MannaChangedDelegate MannaIncreasedEvent;

        public void DecreaseManna(int manna)
        {
            DecreaseManna(manna);
        }

        public void IncreaseManna(int manna)
        {
            Manna += manna;
        }

        public void Prayer()  // Заклинание Молитва
        {

            if (IsDead == true)
            {
                Console.WriteLine($"{Name} мёртв.");
                return;
            }
            else if (Manna >= 10)
            {
                Health += 20;
                Manna -= 10;
                Console.WriteLine($"{Name} использовал заклинание 'Молитва'. Его текущее здоровье: {Health}");

            }
            else
            {
                Console.WriteLine("Недостаточно манны.");
            }
        }

        public void MagicAttack(IHealth unit)
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
                Console.WriteLine($"{Name} нанес магический урон.");
                unit.Health -= 8;
                Manna -= 2;
            }
        }
        public override void DecreaseHealth(int damage)
        {
            Console.WriteLine($"{base.Name} атаковал.");
            base.Health -= (damage - Armor);
        }

        //public virtual void MagicAttack(Unit unit) //Метод НанесенияМагическогоУрона (2 манны = 8 урона)
        //{
        //    if (IsDead == true)
        //    {
        //        Console.WriteLine($"{Name} мёртв.");
        //    }
        //    else if (Manna < 2)
        //    {
        //        Console.WriteLine("Недостаточно манны.");
        //    }
        //    else
        //    {
        //        if (unit.IsDead == true || unit.Health <= 0)
        //        { Console.WriteLine($"Урон невозможен. {unit.Name} мёртв."); }
        //        else
        //        {
        //            unit.Health -= 8;
        //            Manna -= 2;
        //            Console.WriteLine($"{Name} нанес Магический урон {unit.Name}");
        //        }
        //    }
        //}


    }
}
