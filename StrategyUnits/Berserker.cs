using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        private bool _rage;
        public bool Rage
        {
            get { return _rage; }
            set { _rage = value; }
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

                if (base.CurrentHealth < MaxHealth * 0.5 && !_rage)
                {
                    _rage = true;
                    Damage *= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{Name} активировал Ярость!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (base.CurrentHealth >= MaxHealth * 0.5 && _rage)
                {
                    _rage = false;
                    Damage /= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{Name} деактивировал Ярость!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public Berserker(double health, string? name, double damage, double protection) : base(health, name, damage, protection)
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($" Unit: {Name}\n Health: {CurrentHealth}/{MaxHealth}\n Damage: {Damage}\n Protection: {Protection}\n \n Rage: {Rage}\n LvlWeapon: {LvlWeapon}\n LvlArmor: {LvlArmor}");
        }

    }
}
