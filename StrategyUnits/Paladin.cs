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
        private bool _holyArmorActive = false;
        public Paladin(string? name, int health, int minDamage, int maxDamage, int shield, int maxMana) : base(name, health, minDamage, maxDamage, shield, maxMana)
        { 

        }
        public void HolyFire(Unit unit)
        {
            if (Mana >= 3)
            {
                Mana -= 3;
                unit.Health -= 12;
                Console.WriteLine($"{Name} атаковал {unit.Name} магическим ударом");
            }
            else
            {
                Console.WriteLine($"{Name} имеет недостаточно маны. Текущий уровень маны - {Mana}");
            }
        }

        public void HolyArmor()
        {
            if (_holyArmorActive)
            {
                Console.WriteLine($"{Name} уже активировал магическую защиту");
            }
            else
            {
                Shield += Shield / 2;
                Console.WriteLine($"{Name} активировал магическую защиту. Текущая броня - {Shield}");
                _holyArmorActive = true;
                Mana -= 3;
            }
        }
    }
}
