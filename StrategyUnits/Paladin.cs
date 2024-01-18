using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin(int health, string? name) : base(health, name)
        {
            Mana = 30;
            Damage = 5;
            MagicDamage = 8;
        }

        public void FireAttack(Unit unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв");
                return;
            }

            if (unit.Alive == false)
            {
                Console.WriteLine($"{Name} не может атаковать {unit.Name}. Помните о уважении к покойным - не оскверняйте трупы героев, их души заслуживают лучшего. ");
                return;
            }
            if (Mana < 8)
            {
                Console.WriteLine($"У {Name} недостаточно маны для использования заклинания");
                return;
            }
            unit.Health -= MagicDamage;
            Mana -= 8;
            Console.WriteLine($"{Name} атаковал огненным шаром {unit.Name}");
        }

    }
}
