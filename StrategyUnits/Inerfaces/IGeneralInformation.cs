using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IGeneralInformation
    {
        public string? Name { get; set; }
        public void ShowInformation();
    }
}
