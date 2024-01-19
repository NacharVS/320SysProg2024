namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }



        public void InflictDamage(Unit unit)
        {
            if (unit.isAlive)
            {
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} Damage: { _damage} HP:{Health}/{MaxHealth}");
        }

    }
}
