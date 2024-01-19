using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracs // class factory
    {       
        public Footman CreateRecruit()
        {
            return new Footman("Recruit", 60, 2, 5, "копьем", 1);
        }

        public Footman CreateFootman()
        {
            return new Footman("Footman", 90, 3, 10, "мечом", 2);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker("Berserker", 120, 6, 14, "топором", 2);
        }
    }
}
