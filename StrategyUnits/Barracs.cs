using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracs
    {
        public Footman CreateRecruit()
        {
            return new Footman(60, "Recruit", 5, 0);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker(100, "Berserk", 10, 10);
        }

        public Footman CreateFootman()
        {
            return new Footman(80, "Footman", 7, 0);
        }


    }
}
