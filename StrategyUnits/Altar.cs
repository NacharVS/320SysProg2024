using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Altar
    {
		private int _currentEnergy;
        public Altar()
        {
            _currentEnergy = 100;
        }
		public int CurrentEnergy
		{
			get { return _currentEnergy; }
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

        public void RestoreEP(MagicUnit magicUnit)
        {
            var currentEnergyBeforeRestore = magicUnit.CurrentEnergy;
            while (_currentEnergy > 0)
            {
                if (magicUnit.MaxEnergy <= magicUnit.CurrentEnergy)
                {
                    return;
                }
                magicUnit.CurrentEnergy += 10;
                _currentEnergy -= 1;
            }
        }

	}
}
