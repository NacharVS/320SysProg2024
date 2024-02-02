using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : IMagicPower
    {
        public string Name { get; set; }
        private int _energy;
        public int MaxEnergy { get; set; }
        public int Energy
        {
            get { return _energy; }
            set
            {
                int energy1 = _energy;
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > _energy)
                    {
                        _energy = MaxEnergy;
                        Console.WriteLine($"{this.Name} имеет максимальную энергию.\n"); ;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
                if (value < energy1)
                {
                    EnergyDecreasedEvent.Invoke(Name, _energy, energy1 - value, MaxEnergy);
                }
                else if (value > energy1)
                {
                    EnergyIncreasedEvent.Invoke(Name, _energy, energy1 - value, MaxEnergy);
                }
            }
        }
        public Altar(string name, int energy, int maxEnergy)
        {
            Name = name;
            _energy = energy;
            MaxEnergy = maxEnergy;
        }
        public void RegenerationEnergy(IMagicPower magiUnit)
        {
            while (Energy > 0)
            {
                if (magiUnit.MaxEnergy <= magiUnit.Energy)
                {
                    return;
                }
                if (Energy < 2)
                {
                    break;
                }
                magiUnit.IncreaseEnergy(1);
                DecreaseEnergy(2);
            }
        }
        public void DoEnergy()
        {
            while (Energy != MaxEnergy)
            {
                IncreaseEnergy(2);
            }
        }
        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Энергия алтаря: {Energy}/{MaxEnergy}.");
        }
        public void DecreaseEnergy(int energy)
        {
            Energy -= 2;
        }
        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }

        public event IMagicPower.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicPower.EnergyChangedDelegate EnergyIncreasedEvent;

        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", 120, 120, false, 50, 12, 70, 70);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", 100, 100, false, 40, 8, 60, 60, 10);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", 30, 30, false, 15, 15, 5);
        }
    }
}
