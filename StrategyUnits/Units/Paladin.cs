using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Paladin : ZealotKnight, IMagicAttack, IPassiveSkill
    {
        private bool _holyArmorActive = false;
        private double _magicDamage;

        public Paladin(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, double protection, double magicDamage, double damage) : base(name, isDied, currentHealth, maxHealth, energy, maxEnergy, protection, damage)
        {
            MagicDamage = magicDamage;
            PassiveSkillActivate = false;
        }

        public double MagicDamage { get; set; }
        public bool PassiveSkillActivate { get; set; }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(2);
            unit.DecreaseHealth(10);
        }
        public override void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n Здоровье: {CurrentHealth}/{MaxHealth} \n Урон: {Damage}\n Мана: {CurrentEnergy}/{MaxEnergy} \n Магический урон: {MagicDamage} \n Святая броня: {PassiveSkillActivate}\n Живой: {!IsDied}");
        }
        public override double CurrentHealth
        {
            get => base.CurrentHealth;
            set
            {
                double previousHealth = base.CurrentHealth;

                if (value <= 0)
                {
                    base.CurrentHealth = 0;
                    IsDied = true;
                }
                else
                {
                    if (value > MaxHealth)
                        base.CurrentHealth = MaxHealth;
                    else
                        base.CurrentHealth = value;
                }

                if (base.CurrentHealth < MaxHealth * 0.5 && !PassiveSkillActivate && !IsDied)
                {
                    PassiveSkillActivate = true;
                    Protection *= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{Name} активировал Святой щит!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (base.CurrentHealth >= MaxHealth * 0.5 && PassiveSkillActivate && !IsDied)
                {
                    PassiveSkillActivate = false;
                    Protection /= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{Name} деактивировал Святой щит!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }
    }
}
