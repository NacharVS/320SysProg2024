using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barrack // factory class
    {
        //Soldiers
        public Footman CreateRecruit()
        {
            return new Footman(10, "Recruit", 7, 2);
        }
        public Footman CreateFootman()
        {
            return new Footman(14, "Footman", 10, 3);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(20, "Berserker", 13, 5);
        }
    }
}
