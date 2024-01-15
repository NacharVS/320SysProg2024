namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        //Урон
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        //Метод нанесения урона
        public void InflictDamage(Unit unit)
        {
            if (IsDead == true)
                Console.WriteLine("Unit мертв");
            else
            {
                unit.Health -= _damage;
                Console.WriteLine($"Unit нанес {unit.Name} урон {_damage}");
            }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }
    }
}
