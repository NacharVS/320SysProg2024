using StrategyUnits.Interface;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Berserker : Unit, IInflictDamage, IArmor
    {
        private int _armor; //Защита
        private int _damage;
        private bool _rage;
        public Berserker(string? name, int health, int damage, int armor ) : base (name, health)
        {
            _armor = armor;
            _damage = damage;
            _rage = false;

        }

        public int Armor
        {
            get => IArmor.LevelArmor * 2 + _armor;
            set => _armor = value;
        }

        public override int Health
        {
            get => base.Health;
            set
            {
                int begin_health = base.Health;

                if (value < 0)
                {
                    base.Health = 0;
                    IsDead = true;
                    Console.WriteLine($"{Name} мёртв. Нанесения урона невозможно.");
                }
                else
                   if (value > MaxHealth)
                    base.Health = MaxHealth;
                else
                    base.Health = value;


                if (base.Health >= (MaxHealth / 2) && !_rage)
                {

                    _rage = true;
                    _damage += 2;
                    Console.WriteLine("Ярость активирована.");
                }
                else if(base.Health < (MaxHealth / 2) && _rage)
                {
                    _rage = false;
                    _damage -= 2;
                }
                    

            }
        }//Здоровье


        public int Damage
        {
            get => IInflictDamage.LevelWeapon * 2 + _damage;
            set =>  _damage = value;

        }

        public void DecreaseHealth(IHealth unit)
        {

            if (Armor <= Damage)
                Health -= (Damage - Armor);
            else
                Health -= -1 * (Damage - Armor);
        }

        public void InflictDamage(IHealth unit)
        {
            Console.WriteLine($"{Name} атаковал.");
            unit.DecreaseHealth(Damage);
        }

        //public void Rage(IHealth unit) //Ярость Если здоровье больше 50% - Урон + 2
        //{
        //    if (!IsDead)
        //        Console.WriteLine($"{Name} мёртв.");
        //    else
        //    {
        //        if (Health >= (MaxHealth / 2))
        //        {
        //            Damage = Damage + 2;
        //        }
        //    }
        //}

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Состоние жизни: {IsDead} Урон: {Damage} Защита: {Armor}");
        }

        //public void Rage(Unit unit) //Ярость
        //{
        //    if (IsDead == true)
        //        Console.WriteLine($"{Name} мёртв.");
        //    else
        //    {
        //        if (Health <= (MaxHealth / 2)) //(120 > 60)
        //        {
        //            if (unit.IsDead == true || unit.Health <= 0)
        //                Console.WriteLine($"{unit.Name} мёртв. Атака невозможна.");
        //            else
        //            {
        //                unit.Health -= (int)(Damage + (Damage * 0.5)); ;
        //                Console.WriteLine($"{unit.Name} получил урон {Damage + (Damage * 0.5)}");
        //            }
        //        }
        //        else if (Health < (MaxHealth / 2))
        //            Console.WriteLine("Нельзя использовать Ярость");


        //    }
        //}
    }
}
