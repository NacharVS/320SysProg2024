using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        public Altar() 
        {
            MaxEnergy = 100;
        }
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
            while (_currentEnergy > 0)
            {
                while (magicUnit.Mana < magicUnit.MaximumMana)
                {
                    magicUnit.Mana += 10;
                    _currentEnergy-=2;
                }
                return;
            }
            return;
        }
        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", 120, 50, 10, 70);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", 100, 40, 10, 60, 15);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", 55, 30, 6, 40);
        }
    }
}
