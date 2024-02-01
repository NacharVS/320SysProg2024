using StrategyUnits.Extra;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Footman : Unit, IBattleUnit
    {
        private int _damage;
        public Footman(string? name, int health, int maxHealth, bool isDied, int damage) : base(name, health, maxHealth, isDied)
        {
            _damage = damage;
        }
        public int Damage
        {
            get => _damage + 3 * IBattleUnit.WeaponLvl;
            set => _damage = value;
        }
        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Уровень оружия: {IBattleUnit.WeaponLvl} Урон: {Damage}");
        }
    }
}
