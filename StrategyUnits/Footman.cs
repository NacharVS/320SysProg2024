namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (IsDead == true)
                Console.WriteLine("Footman мертв");
            else
            {
                unit.Health -= _damage;
                Console.WriteLine($"Footman нанес {unit.Name} урон {_damage}");
            }
        }

    }
}
