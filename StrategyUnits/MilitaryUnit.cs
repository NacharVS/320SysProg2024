using static System.Net.Mime.MediaTypeNames;
namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public delegate void InflictDamageDelegate(int damage, int maxHP, int maxProtect, string nameDamaging, string nameDamaged);
        public event InflictDamageDelegate inflictDamageEvent;
        public event InflictDamageDelegate inflictDamageToProtectEvent;
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public MilitaryUnit(string? name, int maxHP, int maxProtect, int damage) : base(name, maxHP, maxProtect)
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
                    inflictDamageToProtectEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
                }
                else
                {
                    Console.WriteLine("Защита пробита.");
                    unit.CurrentHP -= _damage;
                    inflictDamageEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
                }
            }
            else
            { 
                Console.WriteLine("Unit is dead.");
            }
        }
    }
}
