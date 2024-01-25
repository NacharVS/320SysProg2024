using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        private bool _holyArmorActive = false;
        public Paladin(int health, string name, int damage, int maxMana, int armor) : base(health, name, damage, maxMana, armor)
        {
        }

        public void FireBall(Unit unit)
        {
            if (unit is MilitaryUnit)
            {
                MilitaryUnit militaryUnit = (MilitaryUnit)unit;
                if (militaryUnit.Armor - 12 >= 0)
                {
                    militaryUnit.Armor -= 12;
                    Console.WriteLine($"{Name} пробил {12} единиц брони {unit.Name}");
                }
                else if (militaryUnit.Armor - 12 < 0 || militaryUnit.Armor == 0)
                {
                    int remains = 12 - militaryUnit.Armor;
                    militaryUnit.Armor -= 12;
                    unit.Health -= remains;
                    Console.WriteLine($"{Name} нанёс {unit.Name} {remains} урона");
                }
                else
                {
                    int remains = 12 - militaryUnit.Armor;
                    militaryUnit.Armor -= 12;
                    unit.Health -= remains;
                    Console.WriteLine($"{Name} пробил броню  {unit.Name}  и нанёс {remains} урона");
                }

            }
            else
            {
                unit.Health -= 12;
                Console.WriteLine($"{Name} нанёс {12} урона по {unit.Name} ");
            }

        }
        public void ArmorHero()
        {
            if (_holyArmorActive && Armor >= 0)
            {
                Armor = 10;
                Console.WriteLine($"У {Name} уже активирована броня максимальное количество раз");
            }
            else
            {
                Armor = +5;
                Console.WriteLine($"{Name} активировал броню: {Armor}");
                _holyArmorActive = true;
                Mana -= 4;
            }
        }
    }
}