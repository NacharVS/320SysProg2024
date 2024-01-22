using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateRecruit()
        {
            return new Footman("Recruit", 60, 20, 7);
        }

        public Footman CreateFootman()
        {
            return new Footman("Footman", 90, 30, 10);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker("Berserker", 120, 30, 15);
        }
    }
}
