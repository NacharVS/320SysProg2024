using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(60, "Paladin", 6)
        {
            Mana = 30;
            Damage = 14;
            MagicDamage = 8;
            Defense = 6;
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
            Console.WriteLine($"{Name} атаковал огненным шаром {unit.Name}");
            unit.Health -= MagicDamage;
            Mana -= 8;
        }

    }
}
