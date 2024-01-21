using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barrack
    {
        public Footman CreateRecruit()
        {
            return new Footman("Recruit", 50, 5, 2);
        }
        public Footman CreateFootman()
        {
            return new Footman("Footman", 50, 7, 3);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker("Berserker", 60, 13, 5);
        }
    }
}
