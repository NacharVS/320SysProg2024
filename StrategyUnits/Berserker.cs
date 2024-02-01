using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Extra;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Berserker : Footman, IArmoredUnit, ICapability
    {
        private int _defense { get; set; }
        public bool CapabilityActive { get; set; }
        public Berserker(string? name, int health, int maxHealth, bool isDied, int damage, int defense) : base(name, health, maxHealth, isDied, damage)
        {
            _defense = defense;
            CapabilityActive = false;
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
        public void CapabilityActivate()
        {
            if (Health < MaxHealth / 2)
            {
                CapabilityActive = true;
                Damage += Damage / 2;
                Console.WriteLine($"{Name} активировал ярость.");
            }
            else
            {
                CapabilityActive = false;
                Damage = Damage;
                Console.WriteLine($"{Name} деактивировал ярость.");
            }
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
            Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Уровень оружия: {IBattleUnit.WeaponLvl} Урон: {Damage} Защита: {Defense} Ярость: {CapabilityActive}");
        }
    }
}
