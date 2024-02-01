using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Berserker : Footman, IArmor
    {
        private int _armor; //Защита
        private bool _rage;
        public Berserker(string? name, int health, int damage, int armor ) : base (name, health, damage)
        {
            _armor = armor;
            _rage = true;

        }

        public int Armor
        {
            get => IArmor.LevelArmor * 2 + _armor;
            set => IArmor.LevelArmor = value;
        }

        public override int Damage
        {
            get => IInflictDamage.LevelWeapon * 2 + base.Damage;
            set /*base.Damage = value;*/
            {

                if (Health >= (MaxHealth / 2))
                {
                    base.Damage += 2;
                }
                else if (Health <= (MaxHealth / 2))
                {
                    base.Damage = value;
                    _rage = false;
                }
            }
        }

        public override void DecreaseHealth(IHealth health)
        {
            Console.WriteLine($"{Name} атаковал.");
            health.DecreaseHealth(Damage - Armor);
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
