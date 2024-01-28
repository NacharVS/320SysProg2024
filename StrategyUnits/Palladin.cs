using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin: ZeelotKnight, IMagicAttack
    {
        private int _hollyFireAttack;
        private int _hollyArmorAttack;

        private int _magicDamage;
        public int MagicDamage;

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

        int IMagicAttack.MagicDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Palladin(int change_heath, int maxHealth, string? name, bool deadperson, int damage, int manna, int maxManna, int guard, int hollyFireAttack) : base(change_heath, maxHealth, name, deadperson, damage, manna, maxManna, guard)
        {
            _hollyFireAttack = hollyFireAttack;
        }

        public void HollyFireAttack(IHealth unit)
        {
            if (DeadPerson == true)
            {
                Console.WriteLine("Palladin died.");
            }
            else if (Change_manna < 4)
            {
                Console.WriteLine("Not enough manna.");
            }
            else
            {
                if (unit.Change_Health <= 0)
                { Console.WriteLine($"Unit can't magic attack. Unit died."); }
                else
                {
                    unit.Change_Health -= (_hollyFireAttack - Guard);
                    Change_manna -= 4;
                    Console.WriteLine($"Palladin take magic attack: Unit Health: {Change_Health}");
                }
            }
        }

        public void HollyArmorAttack(Berserker unit)
        {
            if (DeadPerson)
            {
                Console.WriteLine($"{Name} died.");
            }
            else if (Change_manna < 4)
            {
                Console.WriteLine("Not enough manna.");
            }
            else
            {
                if (unit.DeadPerson == true || unit.Change_Health <= 0)
                { Console.WriteLine($"Palladin take armor magic. {unit.Name} died."); }
                else
                {
                    unit.Guard += 1;
                    Change_manna -= 3;
                    Console.WriteLine($"{Name} cast 'Holy Armor' on  {unit.Name}. Its current armor is: {unit.Guard}");
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} \n Health: {Change_Health}/{MaxHealth}\n Damage: {Damage} \n Guard: {Guard} \n Manna: {this.Change_manna}/{this.MaxManna} \n Magic Attack: {HollyFireAttackk} \n Holy Armor Attack: {HollyArmorAttackk}");
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseManna(2);
            unit.DecreaseHealth(12);
        }
    }
}
