using StrategyUnits.Inerfaces;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class Cleric : Unit, IMagicAbilities, IHealer, IMagicAttack
    {

        public Cleric(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, double magicDamage) : base(name, isDied, currentHealth, maxHealth)
        {
            _currentEnergy = energy;
            MaxEnergy = maxEnergy;
            MagicDamage = magicDamage;
        }
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
                    EnergyDecreasedEvent.Invoke(Name, _currentEnergy, previousEnergy - value, MaxEnergy);
                }
                else if (value > previousEnergy)
                {
                    EnergyIncreasedEvent.Invoke(Name, _currentEnergy, value - previousEnergy, MaxEnergy);
                }
            }
        }
        public int MaxEnergy { get; set; }
        public double MagicDamage { get; set; }

        public void DecreaseEnergy(int energy)
        {
            CurrentEnergy -= 2;
        }

        public void HealSomebody(IHealth unit)
        {
            if (unit.IsDied)
            {
                return;
            }
            while (CurrentEnergy > 0)
            {
                if (unit.MaxHealth <= unit.CurrentHealth)
                {
                    return;
                }
                if (CurrentEnergy < 2)
                {
                    break;
                }
                unit.IncreseHealth(1);
                DecreaseEnergy(2);
            }
        }

        public void IncreaseEnergy(int energy)
        {
            CurrentEnergy += energy;
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(1);
            unit.DecreaseHealth(4);
        }
        public override void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n Здоровье: {CurrentHealth}/{MaxHealth} \n Мана: {CurrentEnergy}/{MaxEnergy} \n Магический урон: {MagicDamage} \n Живой: {!IsDied}");
        }
        public event IMagicAbilities.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicAbilities.EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
