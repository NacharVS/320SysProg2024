using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class ZealotKnight : Unit, IMagicPower, IArmoredUnit, IBattleUnit
    {
        private int _defense;
        private int _damage;
        private int _energy;
        public int MaxEnergy { get; set; }
        public ZealotKnight(string? name, int health, int maxHealth, bool isDied, int defense, int damage, int energy, int maxEnergy) : base(name, health, maxHealth, isDied)
        {
            _defense = defense;
            _damage = damage;
            _energy = energy;
            MaxEnergy = maxEnergy;

        }
        public int Energy
        {
            get { return _energy; }
            set
            {
                int energyChange = _energy;
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
                if (value < energyChange)
                {
                    EnergyDecreasedEvent.Invoke(Name, _energy);
                }
                else if (value > energyChange)
                {
                    EnergyIncreasedEvent.Invoke(Name, _energy);
                }
            }
        }
        public int Defense
        {
            get => _defense;
            set
            {
                if (value < 0)
                {
                    _defense = 0;
                }
                else
                {
                    _defense = value;
                }
            }
        }
        public void Prayer()
        {
            if (IsDead == false)
            {
                if (Energy >= 10)
                {
                    Health += 20;
                    Energy -= 10;
                    Console.WriteLine($"{Name} помолился.");
                }
                else
                {
                    Console.WriteLine($"{Name} не хватает маны.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} мертв.");
            }
        }
        public int Damage
        {
            get => _damage + IBattleUnit.WeaponLvl * 5;
            set => _damage = value;
        }
        public void DecreaseEnergy(int energy)
        {
            Energy -= 2;
        }
        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }
        public override void DecreaseHealth(int damage)
        {
            if (Defense > damage)
            {
                Defense -= damage;
                int currentDamage = damage - Defense;
                base.DecreaseHealth(currentDamage);
            }
            else if (Defense < damage && Defense > 0)
            {
                int balance = damage - Defense;
                Health -= balance;
                base.DecreaseHealth(damage);
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

        public event IMagicPower.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagicPower.EnergyChangedDelegate EnergyIncreasedEvent;
    }
}

