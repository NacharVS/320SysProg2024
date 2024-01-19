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
        //private bool _isHolyArmor;

        //public bool IsHolyArmor
        //{
        //    get { return _isHolyArmor; }
        //    set 
        //    { 
        //        if(CurrentHealth <= MaxHealth / 2)
        //            _isHolyArmor = true;
        //        else
        //            _isHolyArmor = false;
        //    }
        //}
        public Paladin(double health, string? name, double damage, double maxEnergy, double protection, double magicDamage) : base(health, name, damage, maxEnergy, protection)
        {
            _magicDamage = magicDamage;
            //_isHolyArmor = false;
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
        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= (Damage - this.Protection);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurrentHealth}/{MaxHealth} Damage: {Damage} Protection: {Protection} MagicDamage:{MagicDamage}");
        }
    }
}
