using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(string? name, double health, double damage, double maxEnergy, double defence) : base(name, health, damage, maxEnergy, defence)
        {

        }

        public void Player()
        {
            if(NowEnergy >= 10)
            {
                NowEnergy -= 10;
                Health += 20;
            }
            else
            {
                Console.WriteLine("Недостаточно очков энергии для восстановления здоровья");
            }

            if(DiedUnit == true)
            {
                Console.WriteLine($"Персонаж {Name} мертв, действие невозможно");
            }
        }

    }
}
