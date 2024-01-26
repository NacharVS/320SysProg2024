using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class MagicUnit : MilitaryUnit
    {
        public int _manna;
        private int _maxManna;

        public MagicUnit(int health, string name, int damage, int manna) : base(health, name, damage)
        {
            _manna = manna;
            _manna = _maxManna;
        }

        public int manna
        {
            get { return _manna; }
            set { _manna = value; }
        }


        public int _maxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }

        public int Manna
        { 
            get { return manna; }
            set
            { if (value < 0)
                    manna = 0;
             else if (value > _maxManna)
                       manna = _maxManna;
             else
                    Manna = value;
            }
                
        }

    }
}
