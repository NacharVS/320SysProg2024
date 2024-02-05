using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Altar : IMagicAbilities, IGeneralInformation, IAltar
    {
        private int _currentEnergy;

        public Altar(int currentEnergy, int maxEnergy, string? name)
        {
            _currentEnergy = currentEnergy;
            MaxEnergy = maxEnergy;
            Name = name;
        }

        public int CurrentEnergy
        {
            get { return _currentEnergy; }
            set
            {
                int previousEnergy = _currentEnergy;
                if (value < 0)
                {
                    _currentEnergy = 0;
                }
                else
                {
                    if (value > MaxEnergy)
                        _currentEnergy = MaxEnergy;
                    else
                        _currentEnergy = value;
                }
                if (value < previousEnergy)
                {
                    EnergyDecreasedEvent.Invoke(Name, _currentEnergy, previousEnergy - value, MaxEnergy);
                }
                else if (value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(Name, _currentEnergy, value - previousEnergy, MaxEnergy);
                }
            }
        }
        public void DecreaseEnergy(int energy)
        {
            CurrentEnergy -= 2;
        }

        public void IncreaseEnergy(int energy)
        {
            CurrentEnergy += energy;
        }
        public void RestoreEnergy()
        {
            while(CurrentEnergy != MaxEnergy)
            {
                IncreaseEnergy(2);
            }
        }
        public void RecoveryEnergy(IMagicAbilities unit)
        {
            while (CurrentEnergy > 0)
            {
                if (unit.MaxEnergy <= unit.CurrentEnergy)
                {
                    return;
                }
                if (CurrentEnergy < 2)
                {
                    break;
                }
                unit.IncreaseEnergy(1);
                DecreaseEnergy(2);
            }
        }
        public int MaxEnergy { get; set; }
        public string? Name { get; set; }

        public event IMagicAbilities.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicAbilities.EnergyChangedDelegate EnergyIncreasedEvent;
        //Magic units
        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Рыцарь-фанатик", false, 12, 12, 20, 20, 3, 6);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Паладин", false, 18, 18, 30, 30, 6, 22,17);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Целитель", false, 8, 8, 35, 35, 5);
        }

        public void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n Здоровье: {CurrentEnergy}/{MaxEnergy}");
        }
    }
}
