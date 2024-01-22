using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Church
    {
        public Healer CreateHealer()
        {
            return new Healer(50 ,"Healer", 10, 60);
        }
        public Paladin CreateSoulHealer()
        {
            return new Paladin("Paladin2", 10, 60, 100);
        }
    }
}
