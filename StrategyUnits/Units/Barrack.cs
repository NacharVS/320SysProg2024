using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Barrack // factory class
    {
        //Soldiers
        public Footman CreateRecruit()
        {
            return new Footman("Recruit", false, 10, 10, 7);
        }
        public Footman CreateFootman()
        {
            return new Footman("Footman", false, 14, 14, 9);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker("Berserker", false, 20, 20, 12, 10);
        }
    }
}
