namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damage;
        public event HealthChangedDelegate HealthChangedFootman;
        public Footman() : base(60, "Footman")
        {
        }

        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                _damage = random.Next(8, 12);
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }

        }
        public override void ShowInfo()
        {
            HealthChangedFootman.Invoke(Health, Name, null, _damage);
        }

    }
}
