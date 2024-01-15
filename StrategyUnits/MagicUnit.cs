using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _maxEnergy;
        private int _currentEnergy;

        public int CurrentEnergy
        {
            get { return _currentEnergy; }
            set
            {
                if (value > MaxEnergy)
                    _currentEnergy = MaxEnergy;
                else
                    _currentEnergy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public MagicUnit(int health, string? name, int damage, int maxEnergy): base (health, name, damage)
        {
            _maxEnergy = maxEnergy;
            _currentEnergy = maxEnergy;
        }
    }
}
