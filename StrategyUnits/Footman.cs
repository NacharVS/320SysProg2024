using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Footman : Unit, IAttack
    {
        public Footman(string? name, bool isDied, double maxHealth, double damage) : base(name, isDied, maxHealth)
        {
            _damage = damage;
        }
        private double _damage;
        public double Damage 
        { 
            get => _damage + IAttack.LvlWeapon * 2; 
            set => _damage = value; 
        }

        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public virtual void DecreaseHealth(double damage)
        {
            Health -= damage;
        }

        public void IncreaseHealth(double health)
        {
            Health += health;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье = {Health} Уровень оружия = {IAttack.LvlWeapon} Урон = {Damage}");
        }
    }
}
