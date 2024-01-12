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

        public Footman() : base(10, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            unit.CurrentHealth -= _damage;
        }

    }
}
