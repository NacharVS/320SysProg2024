namespace StrategyUnits
{
    internal class Throll : IHealth, IBattleUnit
    {
        public Throll()
        {
            Health = 80;
            Damage = 10;
        }

        public int Health { get; set; }
        public int Damage { get; set; }

        public void Attack(IHealth unit)
        {

            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {          
            Health -= damage;
        }
    }
}
