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
        public int MaxEnergy { get; private set; }

        public Altar(int maxEnergy)
        {
            _currentEnergy = MaxEnergy;
            MaxEnergy = maxEnergy;
        }

        public int CurrentEnergy
        {
            get => _currentEnergy;
            set
            {
                if (value < 0)
                {
                    _currentEnergy = 0;
                }
                else
                {
                    if (value > MaxEnergy)
                    {
                        _currentEnergy = MaxEnergy;
                    }
                    else
                    {
                        _currentEnergy = value;
                    }
                }
            }
        }
        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Energy right now {_currentEnergy}/{MaxEnergy}.");
        }

        public void RecoverMP(MagicUnit magicUnit)
        {
            var currentEnergyBeforeRestore = magicUnit.Mana;
            while (_currentEnergy > 0)
            {
                while (magicUnit.Mana < magicUnit.MaximumMana)
                {
                    magicUnit.Mana += 10;
                    _currentEnergy--;
                }
                return;
            }
        }
    }
}
