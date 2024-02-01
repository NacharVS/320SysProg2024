using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    public interface IMagic
    {
        public int ManaPoints { get; set; }
        public int MaxManaPoints { get; set; }
        public void TakeMana(int manaPoints);
        public void AddMana(int manaPoints);
    }
}
