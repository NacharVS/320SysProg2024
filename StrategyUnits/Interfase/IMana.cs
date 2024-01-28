using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfase
{
    internal interface IMana
    {
        public int Mana { get; set; }
        public int _max_mana { get; set; }

        void RegenerationMana(int mana);
        void SpendMana(int mana);
    }
}
