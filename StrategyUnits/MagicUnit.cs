using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _mana;
        private int _maxMana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value > Mana)
                {
                    if (value > MaxMana)
                        value = MaxMana;
                    Console.WriteLine($"{Name} восстановил ману на {value - Mana}. Текущая мана {value}/{MaxMana}");
                }
                else
                {
                    int waste = Mana - value;
                    if (value < 0)
                        value = 0;
                    Console.WriteLine($"{Name} потратил ману {waste}. Текущая мана {value}/{MaxMana}");
                }
                if (value <= 0)
                {
                    _mana = 0;
                    Console.WriteLine($"{Name} истратил всю ману");
                }
                else if (value > _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }

        public int MaxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }

        public MagicUnit(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield, int maxMana) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield)
        {
            _maxMana = maxMana;
            _mana = maxMana;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Mana: {Mana}/{MaxMana}");
        }
    }
}
