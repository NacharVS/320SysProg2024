using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        public Paladin(int health, string? name, int defense, int damage, int mana, int ArmorLvl, int WeaponLvl) : base(health, name, defense, damage, mana, ArmorLvl, WeaponLvl)
        {
            MagicDamage = 8;
        }

        public void FireAttack(Unit unit)
        {
            if (Alive == false)
            {
                Console.WriteLine($"{Name} не может продолжать битву, он уже мертв");
                return;
            }

            if (unit.Alive == false)
            {
                Console.WriteLine($"{Name} не может атаковать {unit.Name}. Помните о уважении к покойным - не оскверняйте трупы героев, их души заслуживают лучшего. ");
                return;
            }
            if (Mana < 8)
            {
                Console.WriteLine($"У {Name} недостаточно маны для использования заклинания");
                return;
            }
            Console.WriteLine($"{Name} атаковал огненным шаром {unit.Name}");
            unit.Health -= MagicDamage;
            Mana -= 8;
        }

        private bool _holyArmor;
        public bool HolyArmor
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
                    if (value <= MaxHealth / 2 && HolyArmor == false)
                    {
                        HolyArmor = true;
                        Defense *= 2;
                        Console.WriteLine($"У {Name} появился святой щит. Нынешняя защита равна {Defense}");
                    }
                    else if (value > MaxHealth / 2 && HolyArmor == true)
                    {
                        HolyArmor = false;
                        Defense /= 2;
                        Console.WriteLine($"У {Name} пропал святой щит. Нынешняя защита равна {Defense}");
                    }

                }
            }
        }

    }
}
