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
        public MilitaryUnit(string? name, int maxHP, int protection, int damage) : base(name, maxHP, protection)
        {
            _damage = damage;
        }

        public void InflictDamage(Unit unit) 
        {
            if (DeadUnit == false)
            {
                if (unit.Protection > _damage)
                {
                    unit.Protection -= _damage;
                }
                else if (unit.Protection < _damage && unit.Protection > 0)
                {
                    unit.Protection -= _damage;
                    unit.Protection = 0;
                }
                else
                {
                    Console.WriteLine("Защита пробита.");
                    unit.CurrentHP -= _damage;
                    InflictDamageEvent.Invoke(_damage, unit.CurrentHP, Name, unit.Name);
                }
            }
            else
            { 
                Console.WriteLine("Unit is dead.");
            }
        }
        public event InflictDamageDelegate InflictDamageEvent;
    }
}
