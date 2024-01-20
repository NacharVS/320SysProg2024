using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        private double _magicDamage;

        public double MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }
        private bool _holyArmor;

        public bool HolyArmor
        {
            get { return _holyArmor; }
            set { _holyArmor = value; }
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

                if (base.CurrentHealth < MaxHealth * 0.5 && !_holyArmor)
                {
                    _holyArmor = true;
                    Protection *= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{Name} активировал Святой щит!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (base.CurrentHealth >= MaxHealth * 0.5 && _holyArmor)
                {
                    _holyArmor = false;
                    Protection /= 1.5;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{Name} деактивировал Святой щит!");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }
        public Paladin(double health, string? name, double damage, double maxEnergy, double protection, double magicDamage) : base(health, name, damage, maxEnergy, protection)
        {
            _magicDamage = magicDamage;
        }

        public void HolyFire(Unit unit)
        {
            if (this.CurrentEnergy > 0)
            {
                unit.CurrentHealth -= (_magicDamage - unit.Protection);
                CurrentEnergy -= 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{this.Name} нет энергии. Текущая энергия {this.CurrentEnergy}");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name}\n Health: {CurrentHealth}/{MaxHealth}\n Damage: {Damage}\n Protection: {Protection}\n Energy: {this.CurrentEnergy}/{this.MaxEnergy}\n MagicDamage:{MagicDamage}\n HolyArmor: {HolyArmor}\n LvlWeapon: {LvlWeapon}\n LvlArmor: {LvlArmor}");
            Console.WriteLine();
        }
        

    }
}
