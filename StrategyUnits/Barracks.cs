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
            return new Footman(90, 45);
        }
        //public Footman CreateRecruit()
        //{
        //    return new Footman(90, 45);
        //}
    }
}
