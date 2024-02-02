using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Barracks : Building
    {
        public Footman CreateRecruit()
        {
            
            if (Energy >= 10)
            {
                Energy -= 10;
                Console.WriteLine("Призыв рекрута");
                return new Footman(40, 23, 44, 10);
            }
            return null;

        }
        public Footman CreateFootman()
        {
            if (Energy >= 20)
            {
                Energy -= 20;
                Console.WriteLine("Призыв пехотинца");
                return new Footman(60, 30, 50, 15);
            }
            return null;
            
        }
        public Berserker CreateBerserker()
        {
            if (Energy >= 50)
            {
                Energy -= 50;
                Console.WriteLine("Призыв берсерка");
                return new Berserker(200);
            }
            return null;
        }
    }
}
