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
        public Altar(double maxEnergy)
        {
            _maxEnergy = maxEnergy;
            _nowEnergy = maxEnergy;
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

        public void RestoreEnergy()
        {
            while (NowEnergy != MaxEnergy)
            {
                NowEnergy = MaxEnergy;
            }
        }
        public void RecoveryEnergy(IMagicAbilities unit)
        {
            while (NowEnergy > 0)
            {
                if (unit.MaxEnergy <= unit.Energy)
                {
                    return;
                }
                if (NowEnergy < 2)
                {
                    break;
                }
                unit.IncreaseEnergy(1);
                NowEnergy -= 2;
            }
        }

        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", false, 60, 50, 3, 10);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", false, 60, 60, 5, 10, 5);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", false, 60, 50, 8);
        }
    }
}
