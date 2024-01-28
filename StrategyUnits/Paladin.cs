using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight, IMagicAttack, ISkill
    {

        private double _magicDamage;

        public Paladin(string? name, bool isDied, double maxHealth, double maxEnergy, double protection, double magicDamage, double damage) : base(name, isDied, maxHealth, maxEnergy, protection, damage)
        {
            MagicDamage = magicDamage;
            SkillActivate = false;

        }

        public double MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }
        
        public bool SkillActivate 
        {
            get; set;
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(2);
            unit.DecreaseHealth(MagicDamage);
        }

        public override double Health
        {
            get => base.Health;
            set
            {
                double pred_health = base.Health;
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
                    HolyArmor();
                }
                else if (SkillActivate == true && base.Health >= MaxHealth * 0.5)
                {
                    HolyArmorDeactivation();

                }
            }
        }

        public void HolyArmor()
        {
            Protection *= 1.5;
            SkillActivate = true;
            Console.WriteLine($"{Name} активировал святую защиту!");
        }

        public void HolyArmorDeactivation()
        {
            SkillActivate = false;
            Protection /= 1.5;
            Console.WriteLine($"У {Name} святая защита перестала быть активна!");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Персонаж: {Name} Здоровье = {Health}  Урон = {Damage} Энергия = {Energy} Магический урон = {MagicDamage} Святая броня = {SkillActivate}");
        }
        //public void HolyFire(Unit unit)
        //{
        //    if (unit.DiedUnit == false && NowEnergy > 0)
        //    {
        //        NowEnergy -= 1;
        //        unit.Health -= (Damage - unit.Protection);
        //        Console.WriteLine($"Персонажу {unit.Name} нанесен урон с помощью магического удара.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Невозможно использовать магический удар. Персонаж {unit.Name} уже мертв.");
        //    }

        //}


    }
}
