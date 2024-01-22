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
            return new Footman(60,"Recruit",5,7,1,1);
        }
        public Footman CreateFootman() 
        {
            return new Footman(90, "Footman", 7, 12, 1, 1);
        }
        public Berserker CreateBerserker() 
        {
            return new Berserker(120, "Berserker", 7, 15,1,1);
        }
    }
}
