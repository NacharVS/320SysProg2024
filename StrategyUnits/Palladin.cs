using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin: ZeelotKnight
    {
        private int _hollyFireAttack;
        private int _hollyArmorAttack;
        public int HollyFireAttackk
        {
            get { return _hollyFireAttack; }
            set { _hollyFireAttack = value; }
        }

        public int HollyArmorAttackk
        {
            get { return _hollyArmorAttack; }
            set { _hollyArmorAttack = value; }
        }
        public Palladin(int heath, string? name, int damage, int maxManna, int guard, int hollyFireAttack) : base(heath, name, damage, maxManna, guard)
        {
            _hollyFireAttack = hollyFireAttack;
        }

        public void HollyFireAttack(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine("Palladin died.");
            }
            else if (Manna < 4)
            {
                Console.WriteLine("Not enough manna.");
            }
            else
            {
                if (unit.Health <= 0)
                { Console.WriteLine($"Unit can't magic attack. {unit.Name} died."); }
                else
                {
                    unit.Health -= (_hollyFireAttack - Guard);
                    Manna -= 4;
                    Console.WriteLine($"Palladin take magic attack: {unit.Name} Health: {Health}");
                }
            }
        }

        public void HollyArmorAttack(Unit unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine("Palladin died.");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} Health: {Health}/{MaxHealth} Damage: {Damage} Guard: {Guard} Manna: {this.Manna}/{this.MaxManna} Magic Attack: {HollyFireAttackk} Holy Armor Attack: {HollyArmorAttackk} Level Weapon: {LevelWeapon} Level Armor: {LevellArmor}");
        }
    }
}
