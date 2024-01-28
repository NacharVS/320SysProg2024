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
            return new Footman(60, "Recruit", false, 7, 10, 10);
        }

        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", false, 10, 20, 10);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(110, 120, "Berserker", false, 7, 3);
        }
    }
}
