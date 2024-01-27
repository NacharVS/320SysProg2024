using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class ZealotKnight : Unit, IMagicAbilities, IArmoredUnit
    {
        private int _currentEnergy;
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
                    EnergyDecreasedEvent.Invoke(this.Name, _currentEnergy, previousEnergy - value, MaxEnergy);
                }
                else if (value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(this.Name, _currentEnergy, value - previousEnergy, MaxEnergy);
                }
            }
        }
        public int MaxEnergy { get; set; }
        public double Protection { get; set; }
        public ZealotKnight(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, double protection) : base(name, isDied, currentHealth, maxHealth)
        {
            _currentEnergy = energy;
            MaxEnergy = maxEnergy;
            Protection = protection;
        }

        public event IMagicAbilities.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicAbilities.EnergyChangedDelegate EnergyIncreasedEvent;

        public void DecreaseEnergy(int energy)
        {
            CurrentEnergy -= 2;
        }

        public void IncreaseEnergy(int energy)
        {
            CurrentEnergy += energy;
        }
        public void Player()
        {
            if (CurrentEnergy >= 10)
            {
                CurrentEnergy -= 10;
                CurrentHealth += 20;
            }
            else
            {
                Console.WriteLine("Недостаточно очков энергии для восстановления здоровья");
            }

            if (IsDied == true)
            {
                Console.WriteLine($"Персонаж {Name} мертв, действие невозможно");
            }
        }
    }
}
