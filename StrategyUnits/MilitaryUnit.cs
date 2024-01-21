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
        private int _lvlWeapon;
        
        public int LvlWeapon
        {
            get { return _lvlWeapon; }
            set { _lvlWeapon = value; }
        }
        public MilitaryUnit(string? name, double health, double damage, double defence) : base(name, health, defence) 
        {
            _damage = damage;
            _lvlWeapon = 0;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Жизни: {Health} Урон: {Damage} Уровень защиты: {LvlWeapon} Уровень оружия: {LvlArmor}");
        }

        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public virtual void Attack(Unit unit)
        {
            if (unit.DiedUnit == false)
            {
                unit.Health -= (_damage - unit.Defence);
                Console.WriteLine($"Персонаж {Name} нанес урон персонажу {unit.Name} палкой");
            }
            else
                Console.WriteLine($"Нельзя нанести урон персонажу {unit.Name}. Он уже мертв");
        }

        

    }
}
