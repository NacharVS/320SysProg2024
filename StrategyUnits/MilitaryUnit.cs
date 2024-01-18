using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        
        public int _damage;
        

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public MilitaryUnit(int health, string Name) : base(10, Name)
        {
            _damage = 10;
        }
        public void InflictDamage(Unit unit)
        {
            unit.PravHealth = unit.CurentHealth;
            unit.CurentHealth -= _damage;
        }
    }
}
