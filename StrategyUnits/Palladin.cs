using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base("Palladin", 50, 5, "мечом", 40)
        {
        }
        
        public void FireAttack(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может атаковать");
                return;
            }
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Не нужно больше его атаковать");
                return;
            }
            if(Mana < 8)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для огненного заклинания нужно минимум 8 очков маны");
                return;
            }
            Console.WriteLine($"{Name} атаковал огненным заклинанием {unit.Name}");
            unit.Health -= 10;
            Mana -= 8;
        }
    }
}
