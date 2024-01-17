using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _maxEnergy;
        private int _currentEnergy;
        public delegate void EnergyChangedDelegate(string name, int mana, int difference);
        public int CurrentEnergy
        {
            get { return _currentEnergy; }
            set
            {
                int previousEnergy = _currentEnergy;
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
                if(value < previousEnergy)
                {
                    EnergyDecreasedEvent.Invoke(this.Name, CurrentEnergy, previousEnergy - value);
                }
                else if(value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(this.Name, CurrentEnergy, value - previousEnergy);
                }
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public MagicUnit(int health, string? name, int damage, int maxEnergy, int protection): base (health, name, damage, protection)
        {
            _maxEnergy = maxEnergy;
            _currentEnergy = maxEnergy;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.Name} Health: {this.CurrentHealth} Energy: {this.CurrentEnergy}");
        }
        public event EnergyChangedDelegate EnergyDecreasedEvent;
        public event EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
