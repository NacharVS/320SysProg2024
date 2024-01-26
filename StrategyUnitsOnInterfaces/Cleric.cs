using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Cleric : Unit, IMagicUnit
    {
        public Cleric(int health) : base(health)
        {
        }

        public int Mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxMana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
