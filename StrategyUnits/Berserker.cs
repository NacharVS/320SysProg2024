using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        
        public Berserker(int health, string? name, int defense, int damage, int ArmorLvl, int WeaponLvl) : base(health, name, defense, damage, ArmorLvl, WeaponLvl)
        {
  
        }

        private bool _rage;

        public bool Rage
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
                    if (value <= MaxHealth / 2 && Rage == false)
                    {
                        Rage = true;
                        Damage *= 2;
                        Console.WriteLine($"{Name} впал в ярость. Нынешний урон равен {Damage}");
                    }
                    else if (value > MaxHealth / 2 && Rage == true)
                    {
                        Rage = false;
                        Damage /= 2;
                        Console.WriteLine($"{Name} успокоился. Нынешний урон равен {Damage}");
                    }

                }
            }
        }


    }
}
