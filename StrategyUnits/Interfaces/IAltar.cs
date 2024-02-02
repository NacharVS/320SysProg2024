using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IAltar
    {
        public string Name { get; set; }
        public int MaxEnergy { get; set; }
        public int Energy {  get; set; }
        public void RecoverMana(MagicUnit unit);
    }
}
