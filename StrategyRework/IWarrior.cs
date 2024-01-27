using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyRework
{
    internal interface IWarrior:IUnit
    {
        public int Armor { get; set; }
        public int LvlUpArmor { get; set; }
    }
}
