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
                if (unit.Protection > 0)
                {
                    unit.Protection -= _damage;
                    inflictDamageToProtectEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
                }
                else
                {
                    Console.WriteLine("Защита пробита.\n");
                    unit.CurrentHP -= _damage;
                    inflictDamageEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
                }
            }
            else
            { 
                Console.WriteLine($"{Name} мертв.\n");
            }
        }
    }
}
