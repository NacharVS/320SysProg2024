using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Berserker : Footman, IProtection, ISkill
    {
        
        private double _protection;

        public Berserker(string? name, bool isDied, double maxHealth, double damage, double protection) : base(name, isDied, maxHealth, damage)
        {
            _protection = protection;
            SkillActivate = false;
        }

        public double Protection 
        {
            get => IProtection.LvlArmor * 2 + _protection;
            set => _protection = value;
        }
        public bool SkillActivate { get ; set; }

        public override double Health
        {
            get => base.Health;
            set
            {
                if (value <= 0)
                {
                    base.Health = 0;
                    IsDied = true;
                }
                else
                {
                    if (value > MaxHealth)
                        base.Health = MaxHealth;
                    else
                        base.Health = value;
                }

                if (SkillActivate == false && base.Health < MaxHealth * 0.5)
                {
                    PowerRage();
                }
                else if (SkillActivate == true && base.Health >= MaxHealth * 0.5)
                {
                    DeactivationRage();
                }
            }
        }

        public void PowerRage()
        {
            Damage *= 1.5;
            SkillActivate = true;
            Console.WriteLine($"{Name} активировал сверх ярость!");
        }

        public void DeactivationRage()
        {
            SkillActivate = false;
            Damage /= 1.5;
            Console.WriteLine($"У {Name} сверх ярость больше неактивна!");
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


    }
}
