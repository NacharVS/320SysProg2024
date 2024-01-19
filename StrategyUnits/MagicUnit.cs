using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
<<<<<<< Updated upstream
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        public int MaxManna { get; private set; }
        public MagicUnit(int minDamage, int maxDamage, string? name, int Health) : base(minDamage, maxDamage, Health, name )
=======
    internal class MagicUnit : MillitaryUnit
    {
        private int _manna;

        public MagicUnit(int minDamage, int maxDamage, string? name, int Health, int protection) : base(minDamage, maxDamage, name, Health, protection)
>>>>>>> Stashed changes
        {
            _manna = 40;
            MaxManna = _manna;
        }
<<<<<<< Updated upstream
        public int Manna
        {
            get { return _manna; }
            set
            {
=======

        public int MaxManna { get; private set; }

        public int Manna
        {
            get { return _manna; }
            set {
>>>>>>> Stashed changes
                if (value < 0)
                    _manna = 0;
                else if (value > MaxManna)
                    _manna = MaxManna;
                else
                    _manna = value;
            }
        }
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
