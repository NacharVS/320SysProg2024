namespace StrategyUnits
{
    internal class Footman : Unit, IInflictDamage
    {
        private int _damage;
        public Footman(int health, string? name, bool deadperson, int change_health, int maxHealth, int damage) : base(name, change_health, deadperson, maxHealth)
        {
            _damage = damage;
        }

        public int Damage
        {
            get => IInflictDamage.LevelWeapon * 2 + _damage;
            set => _damage = value;
        }
        public void InflictDamage(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public virtual void DecreaseHealth(int damage)
        {
            Change_Health -= damage;
        }

        public void IncreseHealth(int health)
        {
            Change_Health += health;
        }
        //public void InflictDamage(Unit unit)
        //{
        //    if (DeadPerson == true)
        //        Console.WriteLine("Unit died");
        //    else
        //    unit.Health -= _damage;
        //}

        public override void ShowInfo()
        {
            Console.WriteLine($" Character: {Name}\n Health: {Change_Health}/{MaxHealth} \n Damage: {Damage} \n Live? {!DeadPerson}");
        }

    }
}
