using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Akifev320P
{
    internal class Altar
    {
        private int _energy; private int _maxEnergy;
        public Altar()
        {
            _energy = 5000;
            _maxEnergy = _energy;
        }
        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value < 0) _energy = 0;
                else if (value > _maxEnergy) _energy = _maxEnergy;
                else _energy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public void RestoreMana(MagicUnit magicUnit)
        {
            while (magicUnit._maxMana - magicUnit.Manna > 0 && Energy > 0)
            {
                Energy -= 1; magicUnit.Manna += 10;
                Console.WriteLine($"{magicUnit.Name} восстановил ману");
            }
        }
        public Support CreateSupport()
        {
            return new Support(44, "Support", 3, 60);
        }
    }
}