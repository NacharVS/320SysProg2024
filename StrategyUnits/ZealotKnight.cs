using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IMagicAbilities
    {
        public void Player()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                Health += 20;
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
