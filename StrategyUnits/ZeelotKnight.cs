using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class ZeelotKnight : MagicUnit
    {
        public ZeelotKnight(int health, string? name, int armor) : base(40, "Zeelot Knight", 5, 8, 10, 60)
        {
        }
        public void Prayer()
        {
            Health += 20;
            Manna -= 10;
        }
    }
}