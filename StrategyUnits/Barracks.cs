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
            return new Footman(2, 7, "Recruit", 60, 3);
        }
        public Footman CreateFootman()
        {
            return new Footman(5, 10, "Footman", 90, 3);
        }
        public Berserker CreateBerserker()
        {
            
            return new Berserker(10, 15, "Berserker", 120, 5);
        }

    }
}
