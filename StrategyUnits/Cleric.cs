using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Cleric : Unit, IMagicPower, IHealerUnit, IMagicBattleUnit
    {
        private int _energy;
        public int MaxEnergy { get; set; }
        public int MagicDamage { get; set; }

        public Cleric(string name, int health, int maxHealth, bool isDead, int energy, int maxEnergy, int magicDamage) : base (name, health, maxHealth, isDead)
        {
            _energy = energy;
            MaxEnergy = maxEnergy;
            MagicDamage = magicDamage;
        }
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
                    if (value > MaxEnergy)
                        _energy = MaxEnergy;
                    else
                        _energy = value;
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
        public event IMagicPower.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicPower.EnergyChangedDelegate EnergyIncreasedEvent;

        public void Heal(IHealth unit)
        {
            if (unit.IsDead == false)
            {
                if (Energy > 2)
                {
                    while (unit.Health < unit.MaxHealth)
                    {
                        unit.Health++;
                        Energy -= 2;
                    }
                    unit.IncreaseHealth(1);
                    DecreaseEnergy(2);
                }
                else
                {
                    Console.WriteLine($"{this.Name} не хватает энергии.\n");
                }
            }
            else
            {
                Console.WriteLine($"{Name} мертв. Вы не можете вылечить его.\n");
                return;
            }
        }
        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(1);
            unit.DecreaseHealth(MagicDamage);
        }
        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }
        public void DecreaseEnergy(int energy)
        {
            Energy -= energy;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье: {Health}/{MaxHealth} Энергия: {Energy}/{MaxEnergy} Магический урон: {MagicDamage}");
        }
    }
}
