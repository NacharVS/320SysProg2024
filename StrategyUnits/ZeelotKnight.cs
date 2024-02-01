using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class ZeelotKnight : Unit, IMagicUnit, IInflictDamage, IArmor
    {
        private int _manna;
        public int MaxManna { get; set; }
        private int _damage;
        private int _armor;
        public ZeelotKnight(string? name,int health, int damage, int armor,  int manna) : base(name, health)
        {
            _manna = manna;
            MaxManna = manna;
            _damage = damage;
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
                    MannaDecreasedEvent.Invoke( this.Name, Manna, beginManna - value, MaxManna);
                }
                else if (value > beginManna)
                {
                    MannaIncreasedEvent.Invoke(this.Name, Manna,  value - beginManna, MaxManna);
                }
            }
        }

        public int Damage
        {
            get => IInflictDamage.LevelWeapon * 2 + _damage;
            set => _damage = value;
        }
        public int Armor
        {
            get => IArmor.LevelArmor * 2 + _armor;
            set => _armor = value;
        }

        public event IMagicUnit.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnit.MannaChangedDelegate MannaIncreasedEvent;

        public void DecreaseManna(int manna)
        {
            Manna -= 2;
        }

        public void IncreaseManna(int manna)
        {
            Manna += manna;
        }

        public void InflictDamage(IHealth health)
        {
            health.DecreaseHealth(Damage);
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
