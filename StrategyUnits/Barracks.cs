using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks // фабрика
    {
      
        public Footman CreateFootman(string nameOfUnit)
        {
            return new Footman(60, "Рекрут", 2, 5, 20, 50, nameOfUnit, 1, 1);

        }
        public Footman CreateBersekr(string nameOfUnit)
        {
            return new Berserk(100, "Берсерк", 2, 5, 20, 200, nameOfUnit,1,1);

        }

        public Footman CreateRecruit(string nameOfUnit)
        {
            return new Footman(90, "Пехотинец", 2, 5, 20, 100, nameOfUnit, 1, 1);
        }

    }
}
