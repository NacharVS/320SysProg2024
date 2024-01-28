using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Cleric : Unit, IMagicAbilities, IHealer, IMagicAttack
    {
        public Cleric(string? name, bool isDied, double maxHealth, double maxEnergy, double magicDamage) : base(name, isDied, maxHealth)
        {
            MaxEnergy = maxEnergy;
            MagicDamage = magicDamage;
            _energy = maxEnergy;
        }
        private double _energy;
        public double Energy 
        { 
            get { return _energy; } 
            set
            {
                double pred_energy = _energy;
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > MaxEnergy)
                        _energy = MaxEnergy;
                    else
                        _energy = value;
                }
                if (value < pred_energy)
                {
                    EnergyDecreasedEvent.Invoke(Name, _energy);
                }
                else if (value > pred_energy)
                {
                    EnergyIncreasedEvent.Invoke(Name, _energy);
                }
            }
                 
        }

        public event IMagicAbilities.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicAbilities.EnergyChangedDelegate EnergyIncreasedEvent;
        public double MaxEnergy { get; set; }
        public double MagicDamage { get; set; }

        public void DecreaseEnergy(double energy)
        {
            Energy -= 2;
        }

        public void HealSomebody(IHealth unit)
        {
            if (IsDied)
            {
                return;
            }
            while (Energy > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    return;
                }
                if (Energy < 2)
                {
                    break;
                }
                unit.IncreaseHealth(1);
                DecreaseEnergy(2);
            }
        }

        public void IncreaseEnergy(double energy)
        {
            Energy += energy;
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(1);
            unit.DecreaseHealth(MagicDamage);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Персонаж: {Name} Здоровье =  {Health}  Энергия: {Energy} Магический урон: {MagicDamage}");
        }



    }
}
