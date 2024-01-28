using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight, IMagicAttack, IPassiveAbilities
    {
        public Paladin(int health, string? name, int defense, int damage, int mana, int ArmorLvl, int WeaponLvl) : base(health, name, defense, damage, mana, ArmorLvl, WeaponLvl)
        {
            _holyArmor = false;
            MagicDamage = 8;
        }
        private int _magicDamage;
        private bool _holyArmor;
        public bool PassiveAbilities
        {
            get { return _holyArmor; }
            set { _holyArmor = value; }
        }
        public override int Health
        {
            get => base.Health;
            set
            {
                if (value <= 0)
                {
                    base.Health = 0;
                    Alive = false;
                }
                else
                    if (value > MaxHealth)
                    base.Health = MaxHealth;
                else
                {
                    base.Health = value;
                    if (value <= MaxHealth / 2 && PassiveAbilities == false)
                    {
                        PassiveAbilities = true;
                        Defense *= 2;
                        Console.WriteLine($"У {Name} появился святой щит. Нынешняя защита равна {Defense}");
                    }
                    else if (value > MaxHealth / 2 && PassiveAbilities == true)
                    {
                        PassiveAbilities = false;
                        Defense /= 2;
                        Console.WriteLine($"У {Name} пропал святой щит. Нынешняя защита равна {Defense}");
                    }

                }
            }
        }
        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }

        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Мана:{Mana} Защита: {Defense} Урон: {Damage}");
            else
                Console.WriteLine($"{Name} мертв");
        }

        public void InflictMagicDamage(IHealth unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв");
                return;
            }

            if (unit.Alive == false)
            {
                Console.WriteLine($"{Name} не может атаковать противника.");
                return;
            }
            if (Mana < 8)
            {
                Console.WriteLine($"У {Name} недостаточно маны для использования заклинания");
                return;
            }
            Console.WriteLine($"{Name} атаковал огненным шаром");
            unit.TakeDamage(MagicDamage);
            SpendMana(8);
        }
    }
}
