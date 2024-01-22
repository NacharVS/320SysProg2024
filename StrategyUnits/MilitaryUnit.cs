using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _ArmorLvl = 1;
        public int ArmorLvl
        {
            get { return _ArmorLvl; }
            set { _ArmorLvl = value; }
        }

        private int _WeaponLvl = 1;
        public int WeaponLvl
        {
            get { return _WeaponLvl; }
            set { _WeaponLvl = value; }
        }
        private int _damage;
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public MilitaryUnit(int health, string? name, int defense,int damage, int ArmorLvl, int WeaponLvl) : base(health, name, defense)
        {   
            _damage = damage;
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
                int RandomDamage = random.Next(Damage/2 , Damage) - unit.Defense;
                if (RandomDamage <= 0)
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
