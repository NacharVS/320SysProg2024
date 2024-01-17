using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;

        public virtual int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(int health, string? name, int damage, int protection) : base(health, name, protection)
        {
            _damage = damage;
        }
    }
}
