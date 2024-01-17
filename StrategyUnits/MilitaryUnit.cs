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
        
        public MilitaryUnit(string? name, int health, int damage, int defence) : base(name, health, defence) 
        {
            _damage = damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Жизни: {Health} Урон: {Damage}");
        }

        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public virtual void Attack(Unit unit)
        {
            if (unit.DiedUnit == false)
            {
                unit.Health -= (_damage - unit.Defence);
                Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name} ножом");
            }
            else
                Console.WriteLine($"Нельзя нанести урон персонажу {unit.Name}. Он уже мертв");
            
        }
    }
}
