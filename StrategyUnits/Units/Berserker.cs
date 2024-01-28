using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Berserker : Footman, IArmoredUnit, IPassiveSkill
    {
        private double _protection;
        public double Protection
        {
            get => IArmoredUnit.LvlArmor * 2 + _protection;
            set => _protection = value;
        }
        public bool PassiveSkillActivate { get; set; }

        public Berserker(string? name, bool isDied, double currentHealth, double maxHealth, double damage, double protection) : base(name, isDied, currentHealth, maxHealth, damage)
        {
            _protection = protection;
            PassiveSkillActivate = false;
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

                if (base.CurrentHealth < MaxHealth * 0.5 && !PassiveSkillActivate)
                {
                    PassiveSkillActivate = true;
                    Protection *= 1.5;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{Name} активировал Безумство!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (base.CurrentHealth >= MaxHealth * 0.5 && PassiveSkillActivate)
                {
                    PassiveSkillActivate = false;
                    Protection /= 1.5;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{Name} деактивировал Безумство!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }

    }
}
