using System.Xml.Linq;

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
            if (unit.Health > 0)
            {
                unit.Health = Math.Max(unit.Health - _damage, 0);
                if (unit.Health == 0)
                {
                    Console.WriteLine($"Unit {unit.Name} died!");
                }
            }
            else
            {
                Console.WriteLine($"Unit {unit.Name} already died!");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} / Health: {Health} / Damage: {Damage}");
        }

    }
}
