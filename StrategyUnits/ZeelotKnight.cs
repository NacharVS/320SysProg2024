using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class ZeelotKnight : MagicUnit
    {
        public ZeelotKnight(int health, string? name, int armor, int damage, int maxdamage, int manna) : base(health, name, armor, damage, maxdamage, manna)
        {
        }

        public void Prayer()
        {
            Health += 20;
            Manna -= 10;
        }
    }
}