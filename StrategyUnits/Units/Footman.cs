using StrategyUnits.Inerfaces;

namespace StrategyUnits.Units
{
    internal class Footman : Unit, IAttack
    {
        public Footman(string? name, bool isDied, double currentHealth, double maxHealth, double damage) : base(name, isDied, currentHealth, maxHealth)
        {
            _damage = damage;
        }
        private double _damage;
        public double Damage 
        {
            get => IAttack.LvlWeapon * 2 + _damage;
            set => _damage = value;
        }
        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public virtual void DecreaseHealth(double damage)
        {
            CurrentHealth -= damage;
        }

        public void IncreseHealth(double health)
        {
            CurrentHealth += health;
        }
    }
}
