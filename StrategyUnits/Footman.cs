namespace StrategyUnits
{
    internal class Footman : Unit, IInflictDamage
    {
        private int _damage;
        public Footman(string? name, int health, int damage) : base(name, health)
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
            Health -= damage;
        }

        public void IncreseHealth(int health)
        {
            Health += health;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Состоние жизни: {IsDead} Урон: {Damage}");
        }
    }
}
