namespace StrategyUnits
{
    internal class Grunt : IHealth, IBattleUnit, IArmoredUnit
    {
        public Grunt()
        {
            Health = 60;
            Damage = 5;
            Defense = 3;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        public void Attack(IHealth unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }
    }
}
