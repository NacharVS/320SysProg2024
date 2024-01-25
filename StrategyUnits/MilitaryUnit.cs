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
        internal int _levelDamage = 0;
        internal int _levelArmor = 0;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(int health, string name, int damage, int armor) : base(health, name, armor)
        {
            _damage = damage;
        }



        public void Attack(Unit unit)
        {
            if (unit is MilitaryUnit)
            {
                MilitaryUnit militaryUnit = (MilitaryUnit)unit;
                if (militaryUnit.Armor - _damage >= 0)
                {
                    militaryUnit.Armor -= _damage;
                    Console.WriteLine($"{Name} пробил {_damage} единиц брони {unit.Name}");
                }
                else if (militaryUnit.Armor - _damage < 0 || militaryUnit.Armor == 0)
                {
                    int remains = _damage - militaryUnit.Armor;
                    militaryUnit.Armor -= _damage;
                    unit.Health -= remains;
                    Console.WriteLine($"{Name} нанёс {unit.Name} {remains} урона");
                }
                else
                {
                    int remains = _damage - militaryUnit.Armor;
                    militaryUnit.Armor -= _damage;
                    unit.Health -= remains;
                    Console.WriteLine($"{Name} пробил броню  {unit.Name}  и нанёс {remains} урона");
                }
            }

        }
    }
}