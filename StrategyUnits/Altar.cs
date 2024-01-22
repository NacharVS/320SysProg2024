using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {

        private double _nowEnergy;
        private double _maxEnergy;
        public Altar()
        {
            _maxEnergy = 50;
            _nowEnergy = _maxEnergy;
        }
        public double NowEnergy
        {
            get { return _nowEnergy; }
            set
            {
                if (value <= 0)
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

        public double MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }

        public void RestoreEnergy(MagicUnit magicUnit)
        {
            
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

        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", 60, 10, 50, 3);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", 60, 8, 60, 5, 10);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", 60, 7, 3, 50);
        }
    }
}
