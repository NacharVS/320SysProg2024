using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class MilitaryUnit : Unit
    {
        private double _damage;

        public virtual double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(double health, string? name, double damage, double protection) : base(health, name, protection)
        {
            _damage = damage;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurrentHealth} Damage: {Damage}");
        }
    }
}
