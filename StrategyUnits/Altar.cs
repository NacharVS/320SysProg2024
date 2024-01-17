using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {

        private int _nowEnergy;
        private int _maxEnergy;
        public Altar()
        {
            _nowEnergy = 100;
            _maxEnergy = 100;
        }
        public int CurrentEnergy
        {
            get { return _nowEnergy; }
            set
            {
                if (value < 0)
                {
                    _nowEnergy = 0;
                }
                else
                {
                    if (value > _maxEnergy)
                        _nowEnergy = _maxEnergy;
                    else
                        _nowEnergy = value;
                }
            }
        }

        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set
            {
                if (value < 0)
                {
                    _nowEnergy = 0;
                }
                else
                {
                    if (value > _maxEnergy)
                        _nowEnergy = _maxEnergy;
                    else
                        _nowEnergy = value;

                }
            }
        }

        public void RestoreEnergy(MagicUnit magicUnit)
        {
            var currentEnergyBeforeRestore = magicUnit.NowEnergy;
            while (_nowEnergy > 0)
            {
                if (magicUnit.MaxEnergy <= magicUnit.NowEnergy)
                {
                    return;
                }
                magicUnit.NowEnergy += 10;
                _nowEnergy -= 1;
            }
        }
    }
}
