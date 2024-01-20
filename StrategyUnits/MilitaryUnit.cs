using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private double _damage;

        public virtual double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(double health, string? name, double damage, double protection) : base(health, name, protection)
        {
            _damage = damage;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name}\n Health: {CurrentHealth}\n Damage: {Damage}\n LvlWeapon: {LvlWeapon}\n LvlArmor: {LvlArmor}");
            Console.WriteLine();
        }
        public virtual void Attack(Unit unit)
        {
            if (this.IsDied)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"{this.Name} умер. Он не может атаковать");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                return;
            }
            if (this.Damage > unit.Protection)
                unit.CurrentHealth -= (this.Damage - unit.Protection);
            else
                unit.CurrentHealth -= 0;
        }
    }
}
