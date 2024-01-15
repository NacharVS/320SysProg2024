namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public MilitaryUnit(int maxHP, string? name, int damage) : base(maxHP, name)
        {
            _damage = damage;
        }
        //Метод нанесения урона
        public void InflictDamage(Unit unit) 
        {
            if (DeadUnit == false)
            {
                unit.CurrentHP -= _damage;
                Console.WriteLine($"Unit damaged {unit.Name} on {_damage}.");
            }
            else
            { 
                Console.WriteLine("Unit is dead.");
            }
        }
    }
}
