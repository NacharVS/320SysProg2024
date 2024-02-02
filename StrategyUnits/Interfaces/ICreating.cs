using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface ICreating
    {
        public Footman CreateRecruit();
        public Footman CreateFootman();
        public Footman CreateBerserker();
        public Healer CreateHealer(string nameOfUnit);
        public Paladin CreatePaladin(string nameOfUnit);
    }
}
