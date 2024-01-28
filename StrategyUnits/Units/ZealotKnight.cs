using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class ZealotKnight : Unit, IMagicAbilities, IArmoredUnit, IAttack
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
        private double _protection;
        public double Protection
        {
            get => IArmoredUnit.LvlArmor * 2 + _protection;
            set => _protection = value;
        }
        private double _damage;
        public double Damage
        {
            get => IAttack.LvlWeapon * 2 + _damage;
            set => _damage = value;
        }

        public ZealotKnight(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, double protection, double damage) : base(name, isDied, currentHealth, maxHealth)
        {
            _currentEnergy = energy;
            MaxEnergy = maxEnergy;
            _damage = damage;
            _protection = protection;
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
        public override void DecreaseHealth(double damage)
        {
            if (Protection > 0)
            {
                double actualDamage = damage - Protection;
                base.DecreaseHealth(actualDamage);
            }
            else
            {
                base.DecreaseHealth(damage);
            }
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

        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }
    }
}
