namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {
        public event HealthChangedDelegate AttackUnit;
        public int _damage;
        public int MaxDamage;

        public MilitaryUnit(int health, string? name, bool active, int damage, int maxDamage) : base(health, name, active)
        {
            _damage = damage;
            MaxDamage = maxDamage;
        } 

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public virtual void Attack(Unit unit)
        {
            Random random = new Random();
            Damage = random.Next(_damage, MaxDamage);
            unit.Health -= Damage;
            if (unit.Health == 0)
            {
                unit._active = false;
            }
            AttackUnit.Invoke(unit.Health, unit.Name,Damage, null);
        }
    }
}
