using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IHill //Хилл
    {
        public void HillOthers(IHealth health); //Метод лечения другого
    }
}
