using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfase
{
    internal interface IInfoAboutSmth
    {   
        public string Name { get; set; }
        void ShowInfo();
    }
}
