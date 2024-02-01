using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class MagicUnit : MilitaryUnit
    {
        private double _maxEnergy;
        private double _currentEnergy;
        public delegate void EnergyChangedDelegate(string name, double mana, double difference, double maxEnergy);
        public double CurrentEnergy
        {
            get { return _currentEnergy; }
            set
            {
                double previousEnergy = _currentEnergy;
                if (value <= 0)
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
                    EnergyDecreasedEvent.Invoke(Name, CurrentEnergy, previousEnergy - value, _maxEnergy);
                }
                else if (value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(Name, CurrentEnergy, value - previousEnergy, _maxEnergy);
                }
            }
        }
        public double MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public MagicUnit(double health, string? name, double damage, double maxEnergy, double protection) : base(health, name, damage, protection)
        {
            _maxEnergy = maxEnergy;
            _currentEnergy = maxEnergy;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurrentHealth} Energy: {CurrentEnergy}");
        }
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
