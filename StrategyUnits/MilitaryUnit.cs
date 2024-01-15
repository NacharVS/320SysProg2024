using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;
        private int _maxDamage;
        public MilitaryUnit(int damage,int maxDamage,int Health, string? name) : base(Health, name)
        {
            _damage = damage;
            _maxDamage = maxDamage;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public void InflictDamage(Unit unit)
        {
            Random random = new Random();
            if (unit.isAlive)
            {
                unit.Health -= random.Next(_damage, _maxDamage);
                Console.WriteLine(random.Next(_damage, _maxDamage));
            }
            else
            {
                return;
            }
        }
    }
}
