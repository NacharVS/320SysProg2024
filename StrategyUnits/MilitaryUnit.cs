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
        private string _weapon;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public MilitaryUnit(string? name, int maxHealth, int damage, string weapon) : base(name, maxHealth)
        {
            _damage = damage;
            _weapon = weapon;
        }

        public void Attack(Unit unit)
        {
            if(Alive)
            {
                if (unit.Alive)
                {
                    Console.WriteLine($"{Name} атаковал {Weapon} {unit.Name}");
                    unit.Health -= _damage;
                }
                else
                {
                    Console.WriteLine($"{unit.Name} мертв. Его нельзя атаковать");
                }
            }
            else
            {
                Console.WriteLine($"{Name} мертв. Он не может атаковать");
            }
        }
    }
}
