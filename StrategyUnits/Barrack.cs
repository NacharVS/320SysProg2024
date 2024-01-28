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
            return new Footman("Recruit", false, 50, 5);
        }
        public Footman CreateFootman()
        {
            return new Footman("Footman", false, 50, 7);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker("Berserker", false, 60, 13, 5);
        }
    }
}
