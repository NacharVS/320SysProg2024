using static System.Net.Mime.MediaTypeNames;
namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public delegate void InflictDamageDelegate(int damage, int maxHP, string nameDamaging, string nameDamaged);
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

        public void InflictDamage(Unit unit) 
        {
            if (DeadUnit == false)
            {
                unit.CurrentHP -= _damage;
                InflictDamageEvent.Invoke(_damage, unit.CurrentHP, Name, unit.Name);
            }
            else
            { 
                Console.WriteLine("Unit is dead.");
            }
        }

        public event InflictDamageDelegate InflictDamageEvent;
    }
}
