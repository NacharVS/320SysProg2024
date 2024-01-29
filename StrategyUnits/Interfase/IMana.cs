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
        public int _current_mana { get; set; }
        public int _max_mana { get; set; }

        public delegate void RegenerateMana(string? Name, int _current_mana, int _mana, int _max_mana);
        public delegate void DecreasedMana(string? Name, int _current_mana, int _mana, int _max_mana);
        public event RegenerateMana RegenerateManaEvent;
        public event DecreasedMana DecreasedManaEvent;
        void RegenerationMana(int mana);
        void SpendMana(int mana);
    }
}
