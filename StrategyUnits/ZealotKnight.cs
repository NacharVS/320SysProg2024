using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IMagicAbilities, IProtection, IAttack
    {
        

        public void Player()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                Health += 20;
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
                    EnergyDecreasedEvent.Invoke(this.Name, _energy);
                }
                else if (value > pred_energy)
                {
                    EnergyIncreasedEvent.Invoke(this.Name, _energy);
                }
            }
        }
        public double MaxEnergy { get; set; }
        private double _protection;
        public double Protection 
        {
            get => IProtection.LvlArmor * 2 + _protection;
            set => _protection = value;
        }
        private double _damage;

        public ZealotKnight(string? name, bool isDied, double maxHealth, 
            double maxEnergy, double protection, double damage) 
            : base(name, isDied, maxHealth)
        {
            _energy = maxEnergy;
            MaxEnergy = maxEnergy;
            _protection = protection;
            _damage = damage;
        }

        public double Damage 
        {
            get => IAttack.LvlWeapon * 2 + _damage;
            set => _damage = value;
        }

        public void DecreaseEnergy(double energy)
        {
            Energy -= 2;
        }

        public void IncreaseEnergy(double energy)
        {
            Energy += energy;
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

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье = {Health} Урон = {Damage} Энергия = {Energy}");
        }
        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }
        public event IMagicAbilities.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicAbilities.EnergyChangedDelegate EnergyIncreasedEvent;
    }
}
