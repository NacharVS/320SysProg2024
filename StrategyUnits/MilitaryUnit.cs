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

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public MilitaryUnit(int health, string? name) : base(health, name)
        {
            _damage = 5;
        }


        public void InflictDamage(Unit unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв"); 
                return;
            }
            if (unit.Alive)
                unit.Health -= _damage;
            else
                Console.WriteLine($"{Name} не может атаковать {unit.Name}. Помните о уважении к покойным - не оскверняйте трупы героев, их души заслуживают лучшего. ");
        }
    }
}
