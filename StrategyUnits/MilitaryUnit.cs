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

        public delegate void InflictAttackDelegate(int damage, int health, string name, string name_nap);
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
                InflictAttackEvent.Invoke(_damage, unit.Health, unit.Name, Name);
            }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public event InflictAttackDelegate InflictAttackEvent;
    }
}
