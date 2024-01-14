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

        public Footman() : base(60, "Footman", 0, true)
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            Console.WriteLine($"{unit.Name} был атакован и получил {_damage} урона");
            unit.Health -= _damage;
            if(unit.Health == 0)
            {
                Console.WriteLine($"{unit.Name} погиб");
                unit._active = false;
            }
        }

    }
}
