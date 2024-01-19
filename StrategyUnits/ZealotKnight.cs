using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield, int maxMana) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield, maxMana)
        {
        }

        public void Prayer()
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может молиться");
                return;
            }
            if (Health == MaxHealth)
            {
                Console.WriteLine($"{Name} имеет полное здоровье. Молитва не нужна");
                return;
            }
            if (Mana < 10)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для молитвы нужно минимум 10 очка маны");
                return;
            }
            Console.WriteLine($"{Name} помолился");
            Health += 20;
            Mana -= 10;
        }
    }
}
