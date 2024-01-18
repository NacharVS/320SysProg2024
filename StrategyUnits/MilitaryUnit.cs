using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public void InflictDamage(Unit unit)
        {
            if (DeadPerson == true)
                Console.WriteLine("Unit died");
            else
            {
                unit.Health -= _damage;
                //Console.WriteLine($"Unit нанес {unit.Name} урон {_damage}");
                InflictAttackEvent.Invoke(_damage, unit.Health, Name, unit.Name);
            }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }


        public delegate void InflictAttackDelegate(int damage, int health, string name_n, string name_p);
        public event InflictAttackDelegate InflictAttackEvent;
    }
}
