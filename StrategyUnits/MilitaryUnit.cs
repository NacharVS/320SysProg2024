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
        public MilitaryUnit(int health, string? name, int defense) : base(health, name, defense)
        {
            _damage = 15;
        }

        public void InflictDamage(Unit unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв"); 
                return;
            }
            if (unit.Alive)
            {   
                Random random = new Random();
                int RandomDamage = random.Next(Damage/3 , Damage) - unit.Defense;
                if (RandomDamage < 0)
                    Console.WriteLine($"Атака не прошла на {unit.Name}");
                else 
                {
                    Console.WriteLine($"Атака успешно прошла на {unit.Name}");
                    unit.Health -= RandomDamage;                   
                } 
            }
            else
                Console.WriteLine($"{Name} не может атаковать {unit.Name}. Помните о уважении к покойным - не оскверняйте трупы героев, их души заслуживают лучшего. ");
        }
    }
}
