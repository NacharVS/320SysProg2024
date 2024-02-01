using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMainInformation
    {
        public string? Name { get; set; }
        public void ShowInformation();
    }
}
