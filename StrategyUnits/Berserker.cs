using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman, IPassiveAbilities
    {

        public Berserker(int health, string? name, int defense, int damage, int ArmorLvl, int WeaponLvl) : base(health, name, defense, damage, ArmorLvl, WeaponLvl)
        {
            _rage = false;
        }

        private bool _rage;
        public bool PassiveAbilities
        {
            get { return _rage; }
            set { _rage = value; }
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
                        Damage *= 2;
                        Console.WriteLine($"{Name} впал в ярость. Нынешний урон равен {Damage}");
                    }
                    else if (value > MaxHealth / 2 && PassiveAbilities == true)
                    {
                        PassiveAbilities = false;
                        Damage /= 2;
                        Console.WriteLine($"{Name} успокоился. Нынешний урон равен {Damage}");
                    }

                }
            }
        }
        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровье: {Health} Защита: {Defense} Урон: {Damage} Ярость: {PassiveAbilities}");
            else
                Console.WriteLine($"{Name} мертв");
        }

    }
}
