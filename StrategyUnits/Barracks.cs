using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks
    {
      
        public Footman CreateFootman(string nameOfUnit)
        {
            return new Footman(90, "Рекрут", 2, 5, 20, 50, nameOfUnit);

        }
        public Footman CreateBersekr(string nameOfUnit)
        {
            return new Berserk(90, "Рекрут", 2, 5, 20, 200, nameOfUnit);

        }

        internal Footman CreateRecruit(string nameOfUnit)
        {
            return new Footman(90, "Рекрут", 2, 5, 20, 100, nameOfUnit);
        }
    }
}
