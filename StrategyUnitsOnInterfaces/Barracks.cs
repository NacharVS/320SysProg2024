using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Barracks : Building
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, 23,44,10);
        }
        public Footman CreateFootman()
        {
            return new Footman(60, 30, 50, 15);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(200);
        }
    }
}
