using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class ZealotKnight : Unit, IMagicAbilities, IArmoredUnit
    {
        public ZealotKnight(string? name, bool isDied, double currentHealth, double maxHealth) : base(name, isDied, currentHealth, maxHealth)
        {
        }

        public void Player()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                CurrentHealth += 20;
            }
            else
            {
                Console.WriteLine("Недостаточно очков энергии для восстановления здоровья");
            }

            if (IsDied == true)
            {
                Console.WriteLine($"Персонаж {Name} мертв, действие невозможно");
            }
        }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int Protection { get; set; }

        public void DecreaseEnergy(int energy)
        {
            Energy -= 2;
        }

        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }
    }
}
