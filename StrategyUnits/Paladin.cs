using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        private bool _holyArmorActive = false;
        private double _magicDamage;

        public double MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }

        public override double Health
        {
            get => base.Health;
            set
            {
                double previousHealth = base.Health;

                if (value <= 0)
                {
                    base.Health = 0;
                    DiedUnit = true;
                }
                else
                {
                    if (value > MaxHealth)
                        base.Health = MaxHealth;
                    else
                        base.Health = value;
                }

                if (!_holyArmorActive && base.Health < MaxHealth * 0.5)
                {
                    HolyArmor();
                }
                else if ( _holyArmorActive && base.Health >= MaxHealth * 0.5)
                {
                    HolyArmorDeacteved();
                }
            }
        }

        public void HolyArmor()
        {
            Defence *= 1.5;
            _holyArmorActive = true;
            Console.WriteLine($"{Name} активировал святую защиту!");
        }

        public void HolyArmorDeacteved()
        {
            _holyArmorActive = false;
            Defence /= 1.5;
            Console.WriteLine($"У {Name} святая защита перестала быть активна!");
        }
        public Paladin(string? name, double health, double damage, double maxEnergy, 
            double defence, double magicDamage) : base(name, health, damage, maxEnergy, defence)
        {
            _magicDamage = magicDamage;
        }

        public void HolyFire(Unit unit)
        {
            if (unit.DiedUnit == false && NowEnergy > 0)
            {
                NowEnergy -= 1;
                unit.Health -= (Damage - unit.Defence);
                Console.WriteLine($"Персонажу {unit.Name} нанесен урон с помощью магического удара.");
            }
            else
            {
                Console.WriteLine($"Невозможно использовать магический удар. Персонаж {unit.Name} уже мертв.");
            }

        }


    }
}
