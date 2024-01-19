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
        private int _magicDamage;

        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }
        private bool isHolyArmor;

        public bool IsHolyArmor
        {
            get { return isHolyArmor; }
            set { isHolyArmor = value; }
        }
        //public override int Protection
        //{
        //    get 
        //    {
        //        if (isHolyArmor)
        //        {
        //            return Protection * 2;
        //        }
        //        else
        //        {
        //            return Protection;
        //        }
        //    }
        //    set 
        //    {
        //        Protection = value; 
        //    }
        //}
        public Paladin(int health, string? name, int damage, int maxEnergy, int protection, int magicDamage) : base(health, name, damage, maxEnergy, protection)
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
                Console.WriteLine($"{this.Name} not enough energy. Current energy {this.CurrentEnergy}");
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
