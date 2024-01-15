using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
		private int _currentEnergy;

		public int CurrentEnergy
		{
			get { return _currentEnergy; }
			set { _currentEnergy = value; }
		}
		private int _maxEnergy;

		public int MaxEnergy
		{
			get { return _maxEnergy; }
			set
            {
                if (value < 0)
                {
                    _currentEnergy = 0;
                }
                else
                {
                    if (value > _maxEnergy)
                        _currentEnergy = _maxEnergy;
                    else
                        _currentEnergy = value;

                }
            }
		}

        private void RestoreEP(MagicUnit magicUnit)
        {

        }

	}
}
