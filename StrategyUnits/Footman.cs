using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Footman : Unit, IInflictDamage //Юнит, ИУрон
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
            Console.WriteLine($"{Name} атаковал.");
            unit.DecreaseHealth(Damage);
        }

        public virtual void DecreaseHealth(IHealth health)
        {
            Console.WriteLine($"{Name} атаковал.");
            health.DecreaseHealth(Damage);
        }

        public void IncreseHealth(int health)
        {
            Health += health;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Урон: {Damage}\n");
        }
    }
}
